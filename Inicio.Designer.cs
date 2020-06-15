namespace Sistema_administrador_de_taller
{
    partial class Inicio
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
            this.butCatálogodeclientes = new System.Windows.Forms.Button();
            this.butCatálogodeautos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCatálogodeclientes
            // 
            this.butCatálogodeclientes.Location = new System.Drawing.Point(12, 12);
            this.butCatálogodeclientes.Name = "butCatálogodeclientes";
            this.butCatálogodeclientes.Size = new System.Drawing.Size(123, 23);
            this.butCatálogodeclientes.TabIndex = 0;
            this.butCatálogodeclientes.Text = "Catálogo de clientes";
            this.butCatálogodeclientes.UseVisualStyleBackColor = true;
            this.butCatálogodeclientes.Click += new System.EventHandler(this.butCatálogodeclientes_Click);
            // 
            // butCatálogodeautos
            // 
            this.butCatálogodeautos.Location = new System.Drawing.Point(12, 42);
            this.butCatálogodeautos.Name = "butCatálogodeautos";
            this.butCatálogodeautos.Size = new System.Drawing.Size(123, 23);
            this.butCatálogodeautos.TabIndex = 1;
            this.butCatálogodeautos.Text = "Catálogo de autos";
            this.butCatálogodeautos.UseVisualStyleBackColor = true;
            this.butCatálogodeautos.Click += new System.EventHandler(this.butCatálogodeautos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 79);
            this.Controls.Add(this.butCatálogodeautos);
            this.Controls.Add(this.butCatálogodeclientes);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCatálogodeclientes;
        private System.Windows.Forms.Button butCatálogodeautos;
    }
}