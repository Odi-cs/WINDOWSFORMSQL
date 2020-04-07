namespace ADO.NET_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labDatSource = new System.Windows.Forms.Label();
            this.labInitCat = new System.Windows.Forms.Label();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.datGridDBTables = new System.Windows.Forms.DataGridView();
            this.labSQLReq = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Location = new System.Drawing.Point(20, 18);
            this.labDatSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(66, 13);
            this.labDatSource.TabIndex = 0;
            this.labDatSource.Text = "Data Sourse";
            // 
            // labInitCat
            // 
            this.labInitCat.AutoSize = true;
            this.labInitCat.Location = new System.Drawing.Point(20, 47);
            this.labInitCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labInitCat.Name = "labInitCat";
            this.labInitCat.Size = new System.Drawing.Size(70, 13);
            this.labInitCat.TabIndex = 1;
            this.labInitCat.Text = "Initial Catalog";
            // 
            // tbDatSource
            // 
            this.tbDatSource.BackColor = System.Drawing.Color.Sienna;
            this.tbDatSource.ForeColor = System.Drawing.Color.Transparent;
            this.tbDatSource.Location = new System.Drawing.Point(98, 18);
            this.tbDatSource.Margin = new System.Windows.Forms.Padding(2);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(367, 20);
            this.tbDatSource.TabIndex = 2;
            this.tbDatSource.Text = "SQLEXPRESS";
            // 
            // tbInitCat
            // 
            this.tbInitCat.BackColor = System.Drawing.Color.Sienna;
            this.tbInitCat.ForeColor = System.Drawing.Color.White;
            this.tbInitCat.Location = new System.Drawing.Point(98, 47);
            this.tbInitCat.Margin = new System.Windows.Forms.Padding(2);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(265, 20);
            this.tbInitCat.TabIndex = 3;
            this.tbInitCat.Text = "CompShop";
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnect.Location = new System.Drawing.Point(382, 47);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 19);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // datGridDBTables
            // 
            this.datGridDBTables.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.datGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridDBTables.GridColor = System.Drawing.Color.Coral;
            this.datGridDBTables.Location = new System.Drawing.Point(22, 71);
            this.datGridDBTables.Margin = new System.Windows.Forms.Padding(2);
            this.datGridDBTables.Name = "datGridDBTables";
            this.datGridDBTables.RowHeadersWidth = 51;
            this.datGridDBTables.RowTemplate.Height = 24;
            this.datGridDBTables.Size = new System.Drawing.Size(442, 122);
            this.datGridDBTables.TabIndex = 5;
            this.datGridDBTables.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DatGridDBTables_MouseUp);
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Location = new System.Drawing.Point(20, 206);
            this.labSQLReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(71, 13);
            this.labSQLReq.TabIndex = 6;
            this.labSQLReq.Text = "SQL Request";
            // 
            // tbRequest
            // 
            this.tbRequest.BackColor = System.Drawing.Color.Sienna;
            this.tbRequest.ForeColor = System.Drawing.Color.White;
            this.tbRequest.Location = new System.Drawing.Point(98, 203);
            this.tbRequest.Margin = new System.Windows.Forms.Padding(2);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(265, 20);
            this.tbRequest.TabIndex = 7;
            this.tbRequest.Text = "SELECT gname from Goods";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(382, 202);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(83, 19);
            this.btnRequest.TabIndex = 8;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.GridColor = System.Drawing.Color.Coral;
            this.datGridSQLResult.Location = new System.Drawing.Point(22, 226);
            this.datGridSQLResult.Margin = new System.Windows.Forms.Padding(2);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.RowHeadersWidth = 51;
            this.datGridSQLResult.RowTemplate.Height = 24;
            this.datGridSQLResult.Size = new System.Drawing.Size(442, 122);
            this.datGridSQLResult.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(485, 362);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.datGridDBTables);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.labInitCat);
            this.Controls.Add(this.labDatSource);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.Label labInitCat;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView datGridDBTables;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView datGridSQLResult;
    }
}

