using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sucursal
{
    public partial class Form1 : Form
    {
        OleDbConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../virtual.mdb");
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            String usuario = tbuser.Text;
            String clave = tbcont.Text;
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "'";
            conexion.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = conexion;
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            if (reader.Read())
            {
                if (reader["contrasena"].ToString().Equals(clave))// puse if anidado con los tipos segun a o c
                {
                    if (reader["tipo"].Equals("A"))
                    {
                        MessageBox.Show("Bienvenido(a) señor(a) " + tbuser.Text);// para que segun el nombre del usuar lo salude
                        this.Hide();
                        menuadmin menuad = new menuadmin();
                        menuad.Show();
                    }

                    if (reader["tipo"].Equals("C"))
                    {
                        MessageBox.Show("Bienvenido(a) señor(a) " + tbuser.Text );
                        this.Hide(); //para que se cierre la ventana anterior

                        menucliente menuc = new menucliente(); // pasar a la nueva ventana
                        menuc.Show();
                    }
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }

            }
            else
            {
                MessageBox.Show("usuario  no registrado");
            }
            conexion.Close();


        }

       

        private void btsalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
