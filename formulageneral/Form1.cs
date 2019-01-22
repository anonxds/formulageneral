using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulageneral
{
    public partial class Form1 : Form
    {
       
        private void btnresolver_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, x1, x2;

                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);

                x1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                x2 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                lblresultado.Text = "X1= " + x1.ToString();
                lblx2.Text = "X2 = " + x2.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor llene toda la informacion"+ ex);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
