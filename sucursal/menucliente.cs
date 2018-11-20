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
    public partial class menucliente : Form
    {
        public menucliente()
        {
            InitializeComponent();
        }     
        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void menucliente_Load(object sender, EventArgs e)
        {

        }

        private void menucliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void bttransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferencia trans = new transferencia();
            trans.Show();
        }

        private void btmovimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            movimientos mov = new movimientos();
            mov.Show();
        }
    }
}
