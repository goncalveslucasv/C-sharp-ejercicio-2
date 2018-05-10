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
    public partial class frmVentas : Form
    {
        EstaciondeServicio estacion;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Shown(object sender, EventArgs e)
        {
            estacion = ((Form1)this.MdiParent).estacion;
            comboBox1.Items.Add(estacion.Normal);
            comboBox1.Items.Add(estacion.Super);
            comboBox1.Items.Add(estacion.Premium);
            comboBox2.Items.Add(estacion.Surtidor1);
            comboBox2.Items.Add(estacion.Surtidor2);
            comboBox2.Items.Add(estacion.Surtidor3);
            comboBox1.DisplayMember = "descripcion";
            comboBox2.DisplayMember = "numero";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = (Surtidor)comboBox2.SelectedItem;
            Nafta nafta = (Nafta)comboBox1.SelectedItem;

            surtidor.Nafta = nafta;

            comboBox2.Items.Remove(surtidor);
            comboBox1.Items.Remove(nafta);

            listBox1.Items.Add(surtidor);
            listBox1.DisplayMember = "numero";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Surtidor s = (Surtidor)listBox1.SelectedItem;

            float litros = float.Parse(textBox1.Text);

          if(!  s.Vender(litros))
           {
                MessageBox.Show("No hay nafta suficiente");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "1) " + estacion.ObtenerRecaudacion().ToString();
            Surtidor s = (Surtidor)listBox1.SelectedItem;
            label5.Text = "2) " + s.Recaudacion.ToString();
            label6.Text = "3) " + estacion.ObtenerSurtidorMayorRecaudacion().Numero.ToString() ;
            label7.Text = "4) " + estacion.ObtenerSurtidorMenorRecaudacion().Numero.ToString();
            label8.Text = "5) " + estacion.ObtenerSurtidorMayorClientes().Numero.ToString(); 
            label9.Text = "7) " + estacion.DevolverPorcentajedeVentasdeTipoNafta(s.Nafta).ToString()    ;

            label10.Text = "6) " + estacion.DevolverPorcentajedeRecaudaciondeTipoNafta(s.Nafta).ToString();
            label11.Text = "9) " + estacion.ObtenerSurtidorMayorRecargas().Numero.ToString(); ;
            label12.Text = "10) " + estacion.DevolverPromedioVentas().ToString();
            label13.Text = "11) " + estacion.DevolverPromedioRecaudacion().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Surtidor s = (Surtidor)listBox1.SelectedItem;
            s.Recargar();
        }
    }
}
