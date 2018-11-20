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
    public partial class registroclient : Form
    {
        OleDbConnection conexion;
        public registroclient()
        {
            
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../..//virtual.mdb");
        }

        private void btatras_Click(object sender, EventArgs e)
        {


            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        private void btregistrar_Click(object sender, EventArgs e)
        {
            /*this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO usuarios (nombre,contrasena,usuario,direccion,telefono,cedula,correo,tipo) VALUES ('" + this.tbNombre.Text + "','" + this.tbcontrasena.Text + "','" + this.tbusuario.Text + "','" + this.tbdireccion.Text + "','" + this.tbtelefono.Text + "','" + this.tbcedula.Text + "','" + this.tbcorreo.Text + "','" + this.tbtipo.Text + "')";
            conexion.Open();
            this.oleDbDataAdapter1.InsertCommand.Connection = conexion;
            this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Usuario registrado exitosamente");

            tbNombre.ResetText();
            tbusuario.ResetText();
            tbtipo.ResetText();
            tbdireccion.ResetText();
            tbtelefono.ResetText();
            tbcedula.ResetText();
            tbcorreo.ResetText();
            tbcontrasena.ResetText();*/
            if (tbNombre.Modified == false || tbusuario.Modified == false || tbtipo.Modified == false || tbdireccion.Modified == false || tbtelefono.Modified == false || tbcedula.Modified == false || tbcorreo.Modified == false || tbcontrasena.Modified == false)
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {

                try
                {

                    this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO usuarios (nombre,contrasena,usuario,direccion,telefono,cedula,correo,tipo) VALUES ('" + this.tbNombre.Text + "','" + this.tbcontrasena.Text + "','" + this.tbusuario.Text + "','" + this.tbdireccion.Text + "','" + this.tbtelefono.Text + "','" + this.tbcedula.Text + "','" + this.tbcorreo.Text + "','" + this.tbtipo.Text + "')";
                    conexion.Open();
                    this.oleDbDataAdapter1.InsertCommand.Connection = conexion;
                    this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Usuario registrado exitosamente");

                    tbNombre.ResetText();
                    tbusuario.ResetText();
                    tbtipo.ResetText();
                    tbdireccion.ResetText();
                    tbtelefono.ResetText();
                    tbcedula.ResetText();
                    tbcorreo.ResetText();
                    tbcontrasena.ResetText();



                }
                catch (System.Data.OleDb.OleDbException exp)
                {
                    conexion.Close();

                }
            }
        }

        private void registroclient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        private void registroclient_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
     }  
