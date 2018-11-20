using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sucursal
{
    public partial class menuadmin : Form
    {
        public menuadmin()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void btregclient_Click(object sender, EventArgs e)
        {
            this.Hide();
            registroclient regclient = new registroclient();
            regclient.Show();
        }

        private void btregcuent_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrocuenta regcuenta = new registrocuenta();
            regcuenta.Show();
        }

        private void btbusclient_Click(object sender, EventArgs e)
        {
            this.Hide();
            buscarusuario2 buscaru = new buscarusuario2();
            buscaru.Show();
        }

        private void btbuscuent_Click(object sender, EventArgs e)
        {
            this.Hide();
            buscarcuenta2 buscarcu = new buscarcuenta2();
            buscarcu.Show();
        }

        private void menuadmin_Load(object sender, EventArgs e)
        {

        }

        private void menuadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void btvincular_Click(object sender, EventArgs e)
        {
            this.Hide();
            vincular vin = new vincular();
            vin.Show();
        }
    }
}
