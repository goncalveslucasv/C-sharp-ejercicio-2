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
    public partial class frmNafta : Form
    {

        EstaciondeServicio estacion;
        public frmNafta()
        {
            InitializeComponent();
        }

        private void frmNafta_Load(object sender, EventArgs e)
        {
       

        }

        private void frmNafta_Shown(object sender, EventArgs e)
        {
            estacion = ((Form1)this.MdiParent).estacion;
            listBox1.Items.Add(estacion.Normal);
            listBox1.Items.Add(estacion.Super);
            listBox1.Items.Add(estacion.Premium);

            listBox1.DisplayMember = "descripcion";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nafta nafta = (Nafta)listBox1.SelectedItem;
            textBox1.Text = nafta.Precio.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nafta nafta = (Nafta)listBox1.SelectedItem;

            nafta.Precio = float.Parse(textBox1.Text);
        }
    }
}
