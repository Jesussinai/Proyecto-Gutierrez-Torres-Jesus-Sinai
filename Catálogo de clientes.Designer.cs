﻿namespace Sistema_administrador_de_taller
{
    partial class Catálogo_de_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catálogo_de_clientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.tbNOMBRE = new System.Windows.Forms.TextBox();
            this.tbDOMICILIO = new System.Windows.Forms.TextBox();
            this.tbTELEFONO = new System.Windows.Forms.TextBox();
            this.tbCORREO = new System.Windows.Forms.TextBox();
            this.butAGREGAR = new System.Windows.Forms.Button();
            this.butMODIFICAR = new System.Windows.Forms.Button();
            this.butELIMINAR = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCLIENTE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCLIENTE1 = new Sistema_administrador_de_taller.dsCLIENTE();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCLIENTE1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCLIENTE1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo electronico";
            // 
            // tbRFC
            // 
            this.tbRFC.Location = new System.Drawing.Point(24, 86);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(100, 20);
            this.tbRFC.TabIndex = 6;
            // 
            // tbNOMBRE
            // 
            this.tbNOMBRE.Location = new System.Drawing.Point(24, 125);
            this.tbNOMBRE.Name = "tbNOMBRE";
            this.tbNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.tbNOMBRE.TabIndex = 7;
            // 
            // tbDOMICILIO
            // 
            this.tbDOMICILIO.Location = new System.Drawing.Point(24, 164);
            this.tbDOMICILIO.Name = "tbDOMICILIO";
            this.tbDOMICILIO.Size = new System.Drawing.Size(100, 20);
            this.tbDOMICILIO.TabIndex = 8;
            // 
            // tbTELEFONO
            // 
            this.tbTELEFONO.Location = new System.Drawing.Point(24, 203);
            this.tbTELEFONO.Name = "tbTELEFONO";
            this.tbTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.tbTELEFONO.TabIndex = 9;
            // 
            // tbCORREO
            // 
            this.tbCORREO.Location = new System.Drawing.Point(24, 242);
            this.tbCORREO.Name = "tbCORREO";
            this.tbCORREO.Size = new System.Drawing.Size(100, 20);
            this.tbCORREO.TabIndex = 10;
            // 
            // butAGREGAR
            // 
            this.butAGREGAR.Location = new System.Drawing.Point(39, 268);
            this.butAGREGAR.Name = "butAGREGAR";
            this.butAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.butAGREGAR.TabIndex = 11;
            this.butAGREGAR.Text = "AGREGAR";
            this.butAGREGAR.UseVisualStyleBackColor = true;
            this.butAGREGAR.Click += new System.EventHandler(this.butAGREGAR_Click);
            // 
            // butMODIFICAR
            // 
            this.butMODIFICAR.Location = new System.Drawing.Point(130, 83);
            this.butMODIFICAR.Name = "butMODIFICAR";
            this.butMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.butMODIFICAR.TabIndex = 12;
            this.butMODIFICAR.Text = "MODIFICAR";
            this.butMODIFICAR.UseVisualStyleBackColor = true;
            this.butMODIFICAR.Click += new System.EventHandler(this.butMODIFICAR_Click);
            // 
            // butELIMINAR
            // 
            this.butELIMINAR.Location = new System.Drawing.Point(211, 84);
            this.butELIMINAR.Name = "butELIMINAR";
            this.butELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.butELIMINAR.TabIndex = 13;
            this.butELIMINAR.Text = "ELIMINAR";
            this.butELIMINAR.UseVisualStyleBackColor = true;
            this.butELIMINAR.Click += new System.EventHandler(this.butELIMINAR_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        RFC, Nombre, Domicilio, Telefono, [Correo electronico]\r\nFROM       " +
    "     Clientes";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=Taller";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Clientes] ([RFC], [Nombre], [Domicilio], [Telefono], [Correo electro" +
    "nico]) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("RFC", System.Data.OleDb.OleDbType.WChar, 0, "RFC"),
            new System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.WChar, 0, "Nombre"),
            new System.Data.OleDb.OleDbParameter("Domicilio", System.Data.OleDb.OleDbType.WChar, 0, "Domicilio"),
            new System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.Integer, 0, "Telefono"),
            new System.Data.OleDb.OleDbParameter("Correo_electronico", System.Data.OleDb.OleDbType.WChar, 0, "Correo electronico")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("RFC", System.Data.OleDb.OleDbType.WChar, 0, "RFC"),
            new System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.WChar, 0, "Nombre"),
            new System.Data.OleDb.OleDbParameter("Domicilio", System.Data.OleDb.OleDbType.WChar, 0, "Domicilio"),
            new System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.Integer, 0, "Telefono"),
            new System.Data.OleDb.OleDbParameter("Correo_electronico", System.Data.OleDb.OleDbType.WChar, 0, "Correo electronico"),
            new System.Data.OleDb.OleDbParameter("Original_RFC", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Domicilio", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Domicilio", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Correo_electronico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo electronico", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Correo_electronico", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo electronico", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_RFC", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Domicilio", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Domicilio", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Correo_electronico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo electronico", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Correo_electronico", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo electronico", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Clientes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Correo electronico", "Correo electronico")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rFCDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(130, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 281);
            this.dataGridView1.TabIndex = 14;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Correo electronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo electronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsCLIENTE1BindingSource;
            // 
            // dsCLIENTE1BindingSource
            // 
            this.dsCLIENTE1BindingSource.DataSource = this.dsCLIENTE1;
            this.dsCLIENTE1BindingSource.Position = 0;
            // 
            // dsCLIENTE1
            // 
            this.dsCLIENTE1.DataSetName = "dsCLIENTE";
            this.dsCLIENTE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Catálogo_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butELIMINAR);
            this.Controls.Add(this.butMODIFICAR);
            this.Controls.Add(this.butAGREGAR);
            this.Controls.Add(this.tbCORREO);
            this.Controls.Add(this.tbTELEFONO);
            this.Controls.Add(this.tbDOMICILIO);
            this.Controls.Add(this.tbNOMBRE);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Catálogo_de_clientes";
            this.Text = "Catálogo_de_clientes";
            this.Load += new System.EventHandler(this.Catálogo_de_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCLIENTE1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCLIENTE1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.TextBox tbNOMBRE;
        private System.Windows.Forms.TextBox tbDOMICILIO;
        private System.Windows.Forms.TextBox tbTELEFONO;
        private System.Windows.Forms.TextBox tbCORREO;
        private System.Windows.Forms.Button butAGREGAR;
        private System.Windows.Forms.Button butMODIFICAR;
        private System.Windows.Forms.Button butELIMINAR;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource dsCLIENTE1BindingSource;
        private dsCLIENTE dsCLIENTE1;
    }
}