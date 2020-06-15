namespace Sistema_administrador_de_taller
{
    partial class Catálogo_de_autos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catálogo_de_autos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPLACA = new System.Windows.Forms.TextBox();
            this.tbMARCA = new System.Windows.Forms.TextBox();
            this.tbMODELO = new System.Windows.Forms.TextBox();
            this.tbCOLOR = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.dsAUTO1 = new Sistema_administrador_de_taller.dsAUTO();
            this.automóvilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butMODIFICAR = new System.Windows.Forms.Button();
            this.buELIMINAR = new System.Windows.Forms.Button();
            this.butAGREGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAUTO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automóvilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // tbPLACA
            // 
            this.tbPLACA.Location = new System.Drawing.Point(74, 69);
            this.tbPLACA.Name = "tbPLACA";
            this.tbPLACA.Size = new System.Drawing.Size(100, 20);
            this.tbPLACA.TabIndex = 4;
            // 
            // tbMARCA
            // 
            this.tbMARCA.Location = new System.Drawing.Point(74, 108);
            this.tbMARCA.Name = "tbMARCA";
            this.tbMARCA.Size = new System.Drawing.Size(100, 20);
            this.tbMARCA.TabIndex = 5;
            // 
            // tbMODELO
            // 
            this.tbMODELO.Location = new System.Drawing.Point(74, 147);
            this.tbMODELO.Name = "tbMODELO";
            this.tbMODELO.Size = new System.Drawing.Size(100, 20);
            this.tbMODELO.TabIndex = 6;
            // 
            // tbCOLOR
            // 
            this.tbCOLOR.Location = new System.Drawing.Point(74, 186);
            this.tbCOLOR.Name = "tbCOLOR";
            this.tbCOLOR.Size = new System.Drawing.Size(100, 20);
            this.tbCOLOR.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.automóvilesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(192, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 228);
            this.dataGridView1.TabIndex = 8;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Placa, Marca, Modelo, Color\r\nFROM            Automóviles";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Automóviles] ([Placa], [Marca], [Modelo], [Color]) VALUES (?, ?, ?, " +
    "?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Placa", System.Data.OleDb.OleDbType.WChar, 0, "Placa"),
            new System.Data.OleDb.OleDbParameter("Marca", System.Data.OleDb.OleDbType.WChar, 0, "Marca"),
            new System.Data.OleDb.OleDbParameter("Modelo", System.Data.OleDb.OleDbType.WChar, 0, "Modelo"),
            new System.Data.OleDb.OleDbParameter("Color", System.Data.OleDb.OleDbType.WChar, 0, "Color")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection2;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Placa", System.Data.OleDb.OleDbType.WChar, 0, "Placa"),
            new System.Data.OleDb.OleDbParameter("Marca", System.Data.OleDb.OleDbType.WChar, 0, "Marca"),
            new System.Data.OleDb.OleDbParameter("Modelo", System.Data.OleDb.OleDbType.WChar, 0, "Modelo"),
            new System.Data.OleDb.OleDbParameter("Color", System.Data.OleDb.OleDbType.WChar, 0, "Color"),
            new System.Data.OleDb.OleDbParameter("Original_Placa", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Placa", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Marca", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Marca", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Modelo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Modelo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Modelo", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Modelo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Color", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Color", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Color", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Color", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection2;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Placa", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Placa", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Marca", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Marca", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Modelo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Modelo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Modelo", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Modelo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Color", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Color", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Color", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Color", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Automóviles", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Placa", "Placa"),
                        new System.Data.Common.DataColumnMapping("Marca", "Marca"),
                        new System.Data.Common.DataColumnMapping("Modelo", "Modelo"),
                        new System.Data.Common.DataColumnMapping("Color", "Color")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=Taller";
            // 
            // dsAUTO1
            // 
            this.dsAUTO1.DataSetName = "dsAUTO";
            this.dsAUTO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automóvilesBindingSource
            // 
            this.automóvilesBindingSource.DataMember = "Automóviles";
            this.automóvilesBindingSource.DataSource = this.dsAUTO1;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // butMODIFICAR
            // 
            this.butMODIFICAR.Location = new System.Drawing.Point(181, 65);
            this.butMODIFICAR.Name = "butMODIFICAR";
            this.butMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.butMODIFICAR.TabIndex = 9;
            this.butMODIFICAR.Text = "MODIFICAR";
            this.butMODIFICAR.UseVisualStyleBackColor = true;
            this.butMODIFICAR.Click += new System.EventHandler(this.butMODIFICAR_Click);
            // 
            // buELIMINAR
            // 
            this.buELIMINAR.Location = new System.Drawing.Point(263, 65);
            this.buELIMINAR.Name = "buELIMINAR";
            this.buELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.buELIMINAR.TabIndex = 10;
            this.buELIMINAR.Text = "ELIMINAR";
            this.buELIMINAR.UseVisualStyleBackColor = true;
            this.buELIMINAR.Click += new System.EventHandler(this.buELIMINAR_Click);
            // 
            // butAGREGAR
            // 
            this.butAGREGAR.Location = new System.Drawing.Point(86, 212);
            this.butAGREGAR.Name = "butAGREGAR";
            this.butAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.butAGREGAR.TabIndex = 11;
            this.butAGREGAR.Text = "AGREGAR";
            this.butAGREGAR.UseVisualStyleBackColor = true;
            this.butAGREGAR.Click += new System.EventHandler(this.butAGREGAR_Click);
            // 
            // Catálogo_de_autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butAGREGAR);
            this.Controls.Add(this.buELIMINAR);
            this.Controls.Add(this.butMODIFICAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCOLOR);
            this.Controls.Add(this.tbMODELO);
            this.Controls.Add(this.tbMARCA);
            this.Controls.Add(this.tbPLACA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Catálogo_de_autos";
            this.Text = "Catálogo_de_autos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAUTO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automóvilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPLACA;
        private System.Windows.Forms.TextBox tbMARCA;
        private System.Windows.Forms.TextBox tbMODELO;
        private System.Windows.Forms.TextBox tbCOLOR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource automóvilesBindingSource;
        private dsAUTO dsAUTO1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.Button butMODIFICAR;
        private System.Windows.Forms.Button buELIMINAR;
        private System.Windows.Forms.Button butAGREGAR;
    }
}