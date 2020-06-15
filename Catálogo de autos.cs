using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sistema_administrador_de_taller
{
    public partial class Catálogo_de_autos : Form
    {
        public Catálogo_de_autos()
        {
            InitializeComponent();
        }

        private void butAGREGAR_Click(object sender, EventArgs e)
        {
            string query = "Insert into automóviles(Placa, Marca, Modelo, Color) VALUES('" + tbPLACA.Text + "','" + tbMARCA.Text + "','" + tbMODELO.Text + "','" + tbCOLOR.Text +  "')";

            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Taller");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                tbPLACA.Text = "";
                tbMARCA.Text = "";
                tbMODELO.Text = "";
                tbCOLOR.Text = "";
           
                oleDbDataAdapter1.Fill(dsAUTO1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buELIMINAR_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Taller");
            con.Open();
            string query = "Delete from automóviles where Placa = '" + tbPLACA.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            con.Close();
        }

        private void butMODIFICAR_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Taller");
            con.Open();
            string query = "UPDATE automóviles SET MARCA = '" + tbMARCA.Text + "', Modelo = '" + tbMODELO.Text + "', Color = '" + tbCOLOR.Text + "' WHERE Placa = '" + tbPLACA.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se modifico");
            con.Close();
        }
    }
}
