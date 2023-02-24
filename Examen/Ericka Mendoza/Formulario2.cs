using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ericka_Mendoza
{
    public partial class Formulario2 : Syncfusion.Windows.Forms.Office2010Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precioproducto;
            double descuento = 0.15;
            double totalpagar;
            precioproducto = double.Parse(preciotext.Text);
            descuento = double.Parse(descuentotext.Text);

            descuento = precioproducto * 0.15 ;
            totalpagar = precioproducto - descuento;

            totaltextBox.Text = Convert.ToString(totalpagar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            preciotext.Clear();
            descuentotext.Clear();
            totaltextBox.Clear();
            nombretextBox.Clear();
        }
    }
}
