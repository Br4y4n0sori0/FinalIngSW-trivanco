using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace sucursal
{
    public partial class registrocuenta : Form
    {
        OleDbConnection conexion;
        public registrocuenta()
        {
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../virtual.mdb");
        }

        private void btatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        private void btregistrar_Click(object sender, EventArgs e)
        {
            this.oleDbConnection1.Close();

            if (tbNumeroCuenta.Modified == false || tbSaldo.Modified == false)
            {
                MessageBox.Show("llene todos los campos");
            }
            else
            {
                string cuenta = tbNumeroCuenta.Text;
                double numcuent = Convert.ToDouble(cuenta);

                string saldo = tbSaldo.Text;
                double numsaldo = Convert.ToDouble(saldo);

                if (numsaldo >= 10000)
                {

                    if (numcuent >= 10000000000)
                    {
                        if (numcuent <= 99999999999)
                        {
                            try
                            {
                                this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO cuentas (numeroCuenta, saldo) VALUES ('" + this.tbNumeroCuenta.Text + "','" + this.tbSaldo.Text + "')";
                                conexion.Open();
                                this.oleDbDataAdapter1.InsertCommand.Connection = conexion;
                                this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                                conexion.Close();
                                MessageBox.Show("La cuenta ha sido registrada correctamente");
                                tbNumeroCuenta.ResetText();
                                tbSaldo.ResetText();

                            }
                            catch (System.Data.OleDb.OleDbException exp)
                            {
                                conexion.Close();

                                MessageBox.Show("cuenta ya existente");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un número de 11 dígitos");

                        }
                    }
                    else
                    {
                        MessageBox.Show("el numero debe ser de 11 dígitos");
                    }
                }
                else
                {
                    MessageBox.Show("El monto inicial debe ser mayor o igual a $10.000");
                }
            }
        }

        private void registrocuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        private void tbSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
