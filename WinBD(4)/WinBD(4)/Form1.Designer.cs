namespace WinBD_4_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.SectiontextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.FamtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productDataSet2 = new WinBD_4_.ProductDataSet();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.сотрудникиTableAdapter1 = new WinBD_4_.ProductDataSetTableAdapters.СотрудникиTableAdapter();
            this.productDataSet1 = new WinBD_4_.ProductDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(321, 312);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(100, 28);
            this.Nextbutton.TabIndex = 15;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(53, 312);
            this.Previousbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(100, 28);
            this.Previousbutton.TabIndex = 14;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // SectiontextBox
            // 
            this.SectiontextBox.Location = new System.Drawing.Point(174, 234);
            this.SectiontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SectiontextBox.Name = "SectiontextBox";
            this.SectiontextBox.Size = new System.Drawing.Size(132, 22);
            this.SectiontextBox.TabIndex = 13;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(174, 156);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(132, 22);
            this.NametextBox.TabIndex = 12;
            // 
            // FamtextBox
            // 
            this.FamtextBox.Location = new System.Drawing.Point(174, 73);
            this.FamtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FamtextBox.Name = "FamtextBox";
            this.FamtextBox.Size = new System.Drawing.Size(132, 22);
            this.FamtextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отдел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // productDataSet2
            // 
            this.productDataSet2.DataSetName = "ProductDataSet";
            this.productDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT * \r\nFROM     Заказчики";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection2;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `Заказчики` (`Имя`, `Фамилия`, `Город`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Имя", System.Data.OleDb.OleDbType.VarWChar, 0, "Имя"),
            new System.Data.OleDb.OleDbParameter("Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, "Фамилия"),
            new System.Data.OleDb.OleDbParameter("Город", System.Data.OleDb.OleDbType.VarWChar, 0, "Город")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection2;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Имя", System.Data.OleDb.OleDbType.VarWChar, 0, "Имя"),
            new System.Data.OleDb.OleDbParameter("Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, "Фамилия"),
            new System.Data.OleDb.OleDbParameter("Город", System.Data.OleDb.OleDbType.VarWChar, 0, "Город"),
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Имя", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Имя", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Фамилия", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Город", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Город", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Город", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `Заказчики` WHERE ((`Код` = ?) AND ((? = 1 AND `Имя` IS NULL) OR (`Им" +
    "я` = ?)) AND ((? = 1 AND `Фамилия` IS NULL) OR (`Фамилия` = ?)) AND ((? = 1 AND " +
    "`Город` IS NULL) OR (`Город` = ?)))";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection2;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Имя", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Имя", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Имя", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Фамилия", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Фамилия", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Фамилия", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Город", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Город", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Город", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Заказчики", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Имя", "Имя"),
                        new System.Data.Common.DataColumnMapping("Фамилия", "Фамилия"),
                        new System.Data.Common.DataColumnMapping("Город", "Город")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Product.mdb";
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // productDataSet1
            // 
            this.productDataSet1.DataSetName = "ProductDataSet";
            this.productDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.SectiontextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.FamtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ч";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.TextBox SectiontextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox FamtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ProductDataSet productDataSet2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
        private ProductDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private ProductDataSet productDataSet1;
    }
}

