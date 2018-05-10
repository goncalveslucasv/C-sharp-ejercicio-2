using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_3
{
    public partial class Form1 : Form
    {
        public EstaciondeServicio estacion = new EstaciondeServicio();

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNafta frm = new frmNafta();
            frm.MdiParent = this;

            frm.Show();

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmVentas frm = new frmVentas();
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
