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
    public partial class buscarusuario2 : Form
    {


        OleDbConnection conexion;
        public buscarusuario2()
        {
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../virtual.mdb");

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = Convert.ToInt32(tbcedula.Text.ToString());
                this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM usuarios WHERE cedula = " + cedula;
                conexion.Open();
                this.oleDbDataAdapter1.SelectCommand.Connection = conexion;
                OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
                while (reader.Read())
                {
                    tbcedula.Text = reader["cedula"].ToString();
                    tbdireccion.Text = reader["direccion"].ToString();
                    tbtelefono.Text = reader["telefono"].ToString();
                    tbusuario.Text = reader["usuario"].ToString();
                    tbnombre.Text = reader["nombre"].ToString();
                    tbcorreo.Text = reader["correo"].ToString();
                    tbcontrasena.Text = reader["contrasena"].ToString();
                }
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Asegurese de llenar todos los campos requeridos para la busqueda");
            }
            
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            String cedula = tbcedula.Text.ToString();

            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM usuarios WHERE cedula = " + cedula ;
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                
                int actual = Convert.ToInt32(reader["id"].ToString());
                try
                {
                    //cedula = Convert.ToInt32(tbcedula.Text.ToString());
                    this.oleDbDataAdapter2.UpdateCommand.CommandText = "UPDATE usuarios SET " + " usuario = '" + this.tbusuario.Text + "',contrasena = '" + this.tbcontrasena.Text + "',direccion = '" + this.tbdireccion.Text + "',telefono = '" + this.tbtelefono.Text + "',cedula = '" + this.tbcedula.Text + "',correo = '" + this.tbcorreo.Text + "',nombre = '" + this.tbnombre.Text + "'" + "WHERE id = " + actual;
                    this.oleDbConnection2.Open();
                    this.oleDbDataAdapter2.UpdateCommand.Connection = oleDbConnection2;
                    this.oleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                    this.oleDbConnection2.Close();
                    MessageBox.Show("Registro actualizado correctamente.");

                }

                catch (System.Data.OleDb.OleDbException exp)
                {
                    this.oleDbConnection1.Close();
                    MessageBox.Show(exp.ToString());
                }
            }
            this.oleDbConnection1.Close();
            tbcorreo.ResetText();
            tbcedula.ResetText();
            tbnombre.ResetText();
            tbusuario.ResetText();
            tbcontrasena.ResetText();
            tbdireccion.ResetText();
            tbtelefono.ResetText();

        }

    

    private void bteliminar_Click(object sender, EventArgs e)
        {
            

            this.oleDbDataAdapter1.DeleteCommand.CommandText = "DELETE FROM usuarios WHERE cedula ='" + this.tbcedula.Text + "'";
            conexion.Open();
            int cedula = Convert.ToInt32(tbcedula.Text.ToString());
            this.oleDbDataAdapter1.DeleteCommand.Connection = conexion;
            this.oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("usuario eliminado correctamente");
            tbnombre.ResetText();
            tbcedula.ResetText();
            tbtelefono.ResetText();
            tbdireccion.ResetText();
            tbusuario.ResetText();
            tbcorreo.ResetText();
            tbcontrasena.ResetText();
            
        }

        private void btatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }

        

        private void buscarusuario2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            menuadmin menuad = new menuadmin();
            menuad.Show();
        }
    }
    }

