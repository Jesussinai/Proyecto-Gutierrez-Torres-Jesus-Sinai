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
    public partial class Catálogo_de_clientes : Form
    {
        public Catálogo_de_clientes()
        {
            InitializeComponent();
        }

        private void butAGREGAR_Click(object sender, EventArgs e)
        {
            string query = "Insert into Clientes(RFC, Nombre, Domicilio, Telefono, [Correo electronico]) VALUES('" + tbRFC.Text + "','" + tbNOMBRE.Text + "','" + tbDOMICILIO.Text + "','" + tbTELEFONO.Text + "','" + tbCORREO.Text + "')";

            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Taller");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                tbRFC.Text = "";
                tbNOMBRE.Text = "";
                tbDOMICILIO.Text = "";
                tbTELEFONO.Text = "";
                tbCORREO.Text = "";
                oleDbDataAdapter1.Fill(dsCLIENTE1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butELIMINAR_Click(object sender, EventArgs e)
        {
         
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Taller");
            con.Open();
            string query = "Delete from Clientes where RFC = '" + tbRFC.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            con.Close();
        }

        private void butMODIFICAR_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-R39N3KF\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Taller");
            con.Open();
            string query = "UPDATE Clientes SET Nombre = '" + tbNOMBRE.Text + "', Domicilio = '" + tbDOMICILIO.Text + "', Telefono = '" + tbTELEFONO.Text + "', [Correo electronico]='" + tbCORREO.Text + "' WHERE RFC = '" + tbRFC.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se modifico");
            con.Close();
        }

        private void Catálogo_de_clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
