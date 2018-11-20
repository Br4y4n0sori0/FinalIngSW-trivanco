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
    public partial class transferencia : Form
    {
        public transferencia()
        {
            InitializeComponent();
        }

        private void btatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menucliente trans = new menucliente();
            trans.Show();
        }

        private void transferencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            menucliente trans = new menucliente();
            trans.Show();
        }

        private void bttransferir_Click(object sender, EventArgs e)
        {
            String numerocuenta = this.tbcuentaorigen.Text;
            String numerocuenta2 = this.tbcuentadestino.Text;
            int monto = Convert.ToInt32(this.tbmonto.Text);
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM cuentas WHERE numeroCuenta = '" + numerocuenta + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            reader.Read();
            int saldoOrigen = Convert.ToInt32(reader["saldo"]);
            int actual = Convert.ToInt32(reader["id"].ToString());
            this.oleDbConnection1.Close();


            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM cuentas WHERE numeroCuenta = '" + numerocuenta2 + "'";
            //this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            OleDbDataReader reader1 = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            reader1.Read();
            int saldoDestino = Convert.ToInt32(reader1["saldo"]);
            int actual1 = Convert.ToInt32(reader1["id"].ToString());
            this.oleDbConnection1.Close();

            if (monto >= 10000)
            {
                try
                {
                    saldoDestino = saldoDestino + monto;
                    saldoOrigen = saldoOrigen - monto;
                    String saldoFinalOrigen = Convert.ToString(saldoOrigen);
                    this.oleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE cuentas SET " + " saldo = '" + saldoFinalOrigen + "'" + "WHERE id = " + actual;
                    this.oleDbConnection1.Open();
                    this.oleDbDataAdapter1.UpdateCommand.Connection = oleDbConnection1;
                    this.oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
                    this.oleDbConnection1.Close();

                    String saldoFinalDestino = Convert.ToString(saldoDestino);
                    this.oleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE cuentas SET " + " saldo = '" + saldoFinalDestino + "'" + "WHERE id = " + actual1;
                    this.oleDbConnection1.Open();
                    this.oleDbDataAdapter1.UpdateCommand.Connection = oleDbConnection1;
                    this.oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
                    this.oleDbConnection1.Close();

                    MessageBox.Show("La transferencia por un valor de " + monto + ", se ha realizado correctamente ");
                    tbcuentadestino.ResetText();
                    tbcuentaorigen.ResetText();
                    tbmonto.ResetText();
                }
                catch (System.Data.OleDb.OleDbException exp)
                {
                    MessageBox.Show("Transferencia no realizada");
                }



            }
            else
            {
                MessageBox.Show("Transferencia no realizada");
            }
            /*try
            {
                String numerocuenta = this.tbcuentaorigen.Text;
                String numerocuenta2 = this.tbcuentadestino.Text;
                int monto = Convert.ToInt32(this.tbmonto.Text);
                this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM cuentas WHERE numeroCuenta = '" + numerocuenta + "'";
                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
                OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
                reader.Read();
                int saldoOrigen = Convert.ToInt32(reader["saldo"]);
                int actual = Convert.ToInt32(reader["id"].ToString());
                this.oleDbConnection1.Close();


                this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM cuentas WHERE numeroCuenta = '" + numerocuenta2 + "'";
                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
                OleDbDataReader reader1 = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
                reader1.Read();
                int saldoDestino = Convert.ToInt32(reader1["saldo"]);
                int actual1 = Convert.ToInt32(reader1["id"].ToString());
                this.oleDbConnection1.Close();

                if (monto >= 10000)
                {
                    try
                    {
                        saldoDestino = saldoDestino + monto;
                        saldoOrigen = saldoOrigen - monto;
                        String saldoFinalOrigen = Convert.ToString(saldoOrigen);
                        this.oleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE cuentas SET " + " saldo = '" + saldoFinalOrigen + "'" + "WHERE id = " + actual;
                        this.oleDbConnection1.Open();
                        this.oleDbDataAdapter1.UpdateCommand.Connection = oleDbConnection1;
                        this.oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
                        this.oleDbConnection1.Close();

                        String saldoFinalDestino = Convert.ToString(saldoDestino);
                        this.oleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE cuentas SET " + " saldo = '" + saldoFinalDestino + "'" + "WHERE id = " + actual1;
                        this.oleDbConnection1.Open();
                        this.oleDbDataAdapter1.UpdateCommand.Connection = oleDbConnection1;
                        this.oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
                        this.oleDbConnection1.Close();

                        MessageBox.Show("La transferencia por un valor de " + monto + ", se ha realizado correctamente ");
                        tbcuentadestino.ResetText();
                        tbcuentaorigen.ResetText();
                        tbmonto.ResetText();
                    }
                    catch (System.Data.OleDb.OleDbException exp)
                    {
                        MessageBox.Show("Transferencia no realizada");
                    }



                }
                else
                {
                    MessageBox.Show("Transferencia no realizada");
                }
            }
            catch
            {
                MessageBox.Show("Asegurese de llenar todos los campos.");
            }*/

        }
    }
}
