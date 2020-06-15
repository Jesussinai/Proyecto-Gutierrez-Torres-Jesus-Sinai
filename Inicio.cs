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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void butCatálogodeclientes_Click(object sender, EventArgs e)
        {
            Catálogo_de_clientes llamar = new Catálogo_de_clientes();
            llamar.Show();
        }

        private void butCatálogodeautos_Click(object sender, EventArgs e)
        {
            Catálogo_de_autos llamar = new Catálogo_de_autos();
            llamar.Show();
        }
    }
}
