using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_1
{
    class DBRequest
    {
        private SqlConnection DBCon = new SqlConnection();
        public void ConnectTo(string DataSource, string InitialCatalog) 
        { 
            DBCon.ConnectionString = @"Data Source= .\" + DataSource + ";Initial Catalog=" + InitialCatalog + ";Integrated Security=True";
            try 
            { 
                DBCon.Open();
                MessageBox.Show("Done!", "Connection...");
            } 
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            } 
        }

        public void Disconnect() 
        {
            try 
            { 
                if (DBCon.State == ConnectionState.Open) 
                    DBCon.Close(); 
            } 
            catch 
            { 
            } 
        }

        ~DBRequest() 
        { 
            Disconnect(); 
        }

        public string GetTableFields(string TableName)
        {
            if (DBCon.State == ConnectionState.Open)                
            { 
                DataTable CurTable = new DataTable("ConnectedTab");
                SqlDataAdapter DBAdapt;
                try 
                {
                    DBAdapt = new SqlDataAdapter("SELECT * FROM " + TableName, DBCon);
                    DBAdapt.Fill(CurTable);
                } 
                catch (Exception e)
                { 
                    throw e;
                } 
                string ResStr = "";
                int ColCount = CurTable.Columns.Count;
                for (int i = 0; i < ColCount; i++)
                { 
                    string StrCon = ", ";
                    if (i == ColCount - 1) 
                        StrCon = ";";
                    ResStr += CurTable.Columns[i].ColumnName + "[" + 
                              CurTable.Columns[i].DataType.Name + "]" + StrCon;
                } 
                return ResStr;
            }       
            else return null;
        }

        public DataTable SQLRequest(string RequestStr)
        {
            if (DBCon.State == ConnectionState.Open)
            { 
                DataTable ResultTab = new DataTable("SQLresult");
                SqlDataAdapter DBAdapt;
                try 
                {
                    DBAdapt = new SqlDataAdapter(RequestStr, DBCon);
                    DBAdapt.Fill(ResultTab);
                } 
                catch (Exception e)
                { 
                    throw e; 
                } 
                return ResultTab; 
            }
            else
                return null;
        }
    }
}
