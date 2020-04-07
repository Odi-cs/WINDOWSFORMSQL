using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
          
            bool Connected = false;
            Cursor = Cursors.WaitCursor;
           
            try
            {
                UserReq.Disconnect();
                UserReq.ConnectTo(tbDatSource.Text, tbInitCat.Text);
                Connected = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Connected = false;
            }
            if (Connected)
            {
                // Открываем доступ к управлению выполнением запросов:
                tbRequest.Enabled = true;
                btnRequest.Enabled = true;
                datGridSQLResult.Enabled = true;
                datGridDBTables.Enabled = true;
            }
            else
            {// Закрываем доступ к управлению выполнением запросов:  
                tbRequest.Enabled = false;
                btnRequest.Enabled = false;
                datGridSQLResult.Enabled = false;
                datGridDBTables.Enabled = false;
            }
            Cursor = Cursors.Arrow;
            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            {
            }
        }

        // Класс выполняющий соединение с БД и запрос к ней:
        private DBRequest UserReq;
        // Таблица-результат выполнения запроса: 
        private DataTable RequestTab;
        // Таблица структуры таблиц из БД:   
        private DataTable StructTab;    
        // Название Таблицы, обработанной последний раз в StructTab_OnRowChanged
        private string LastTabName;

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Создаём класс взаимодействия с Базой Данных
            UserReq = new DBRequest();
            // Создаём таблицу и добавляем в неё столбцы:   
            StructTab = new DataTable("TabFields");
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            datGridDBTables.DataSource = StructTab;

            datGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab;
            // Подключаем к таблице обработчик события изменения строки: 
            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged);
        }

        private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RequestTab = UserReq.SQLRequest(tbRequest.Text);
                datGridSQLResult.DataSource = RequestTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }

        private void DatGridDBTables_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo HitInfo = datGridDBTables.HitTest(e.X, e.Y);//HitTest(e.X, e.Y);
            if ((HitInfo.RowIndex >= 0) && (HitInfo.RowIndex < StructTab.Rows.Count))
            {
                tbRequest.Text = "SELECT * FROM " + (string)StructTab.Rows[HitInfo.RowIndex][
                "Tables"];
                btnRequest_Click(this, null);
            }
        }
  
    }
}
