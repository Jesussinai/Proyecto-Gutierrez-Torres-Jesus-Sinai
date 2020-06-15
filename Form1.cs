using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_administrador_de_taller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (this.tbUsuario.Text == "Admin" && this.tbContraseña.Text == "123")
            {
                Inicio llamar = new Inicio();
                llamar.Show();
            }
            else
            {
                MessageBox.Show("Error este usuario no existe");
            }
        }
    }
}
