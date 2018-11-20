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

namespace sucursal
{
    public partial class vincular : Form
    {
        OleDbConnection conexion;
        public vincular()
        {
            InitializeComponent();
            buscarusuario2 buscarusuario;
            buscarusuario = new buscarusuario2();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../virtual.mdb");
        }

        private void vincular_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
           menuadmin men = new menuadmin();
            men.Show();
        }

        private void btatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuadmin men = new menuadmin();
            men.Show();
        }

        private void btvincular_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(tbcedula.Text.ToString());
            try
            {
                this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO vinculaciones (cedula,cuenta) VALUES ('" + cedula + "','" + this.tbcuenta.Text + "')";
                conexion.Open();
                this.oleDbDataAdapter1.InsertCommand.Connection = conexion;
                this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Vinculacion realizada exitosamente");
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                MessageBox.Show("No se pudo realizar la vinculacion, verifique los datos");
            }

            tbcuenta.ResetText();
            tbcedula.ResetText();
            
        }

       
    }
}
