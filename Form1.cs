using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KureHacmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Küre Hacmi = 4/3 * pi * r^3

            double r = Convert.ToDouble(txtYaricap.Text);

            double hacim = (4 * Math.PI * Math.Pow(r, 3)) / 3;

            txtHacim.Text = Convert.ToString(hacim) + "  m^3";

        }
    }
}
