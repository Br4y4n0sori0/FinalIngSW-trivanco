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
    public partial class buscarcuenta2 : Form
    {
        OleDbConnection conexion;
        public buscarcuenta2()
        {
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../virtual.mdb");
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String numcuenta = tbnumcuenta.Text;
                this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM cuentas WHERE numeroCuenta = '" + numcuenta + "'";
                conexion.Open();
                this.oleDbDataAdapter1.SelectCommand.Connection = conexion;
                OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
                while (reader.Read())
                {
                    tbnumcuenta.Text = reader["numeroCuenta"].ToString();
                    tbsaldo.Text = reader["saldo"].ToString();
                }
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Asegurese de llenar todos los campos");
            }
            

        }

        private void btatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        private void buscarcuenta2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            this.oleDbDataAdapter1.DeleteCommand.CommandText = "DELETE FROM cuentas WHERE numeroCuenta ='" + this.tbnumcuenta.Text + "'";
            conexion.Open();
            this.oleDbDataAdapter1.DeleteCommand.Connection = conexion;
            this.oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Cuenta eliminada correctamente");
            tbnumcuenta.ResetText();
            tbsaldo.ResetText();
            
        }
    }
}
