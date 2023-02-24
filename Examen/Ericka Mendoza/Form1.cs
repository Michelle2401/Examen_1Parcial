using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ericka_Mendoza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {
            Formulario1 userForm1 = new Formulario1();
            userForm1.MdiParent = this;
            userForm1.Show();

        }

        private void toolStripTabItem2_Click(object sender, EventArgs e)
        {
            Formulario2 userForm2 = new Formulario2();
            userForm2.MdiParent = this;
            userForm2.Show();
        }

        private void toolStripTabItem3_Click(object sender, EventArgs e)
        {
            Formulario3 userForm3 = new Formulario3();
            userForm3.MdiParent = this;
            userForm3.Show();
        }
    }
}
