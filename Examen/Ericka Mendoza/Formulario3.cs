using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ericka_Mendoza
{
    public partial class Formulario3 : Syncfusion.Windows.Forms.Office2010Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int desde = Convert.ToInt32(desdetexBox.Value);
            int hasta = Convert.ToInt32(hastatexBox.Value);
            int multiplo = Convert.ToInt32(multiplotextBox.Text);

            for (int i = desde; i <= hasta; i++)
            {
                if (i % multiplo == 0)
                {
                    list.Items.Add(i);

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiplotextBox.Clear();

            list.Items.Clear();
        }

        
    }
}
