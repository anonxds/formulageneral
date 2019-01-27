using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace formulageneral
{
    public partial class Form1 : Form
    {

        //   SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Reborn 3.0\Documents\GitHub\formulageneral\formulageneral\datos.mdf;Integrated Security = True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\datos.mdf;Integrated Security=True");
        private void btnresolver_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String st = "insert into datos (fecha,A,B,C,x1,x2)values(@fecha,@A,@B,@C,@x1,@x2)";
                SqlCommand cmd = new SqlCommand(st,con);

                double a, b, c, x1, x2;

                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("@A", txta.Text);
                cmd.Parameters.AddWithValue("@B", txtb.Text);
                cmd.Parameters.AddWithValue("@C", txtc.Text);
             
                x1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                x2 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                lblresultado.Text = "X1= " + x1.ToString();
                lblx2.Text = "X2 = " + x2.ToString();
                cmd.Parameters.AddWithValue("@x1", x1.ToString());
                cmd.Parameters.AddWithValue("@x2", x2.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor llene toda la informacion"+ ex);
            }
        }

        public Form1()
        {
            InitializeComponent();
            con.Open();
            SqlDataAdapter sqldata = new SqlDataAdapter("select * from datos", con);
            DataTable dtlb = new DataTable();
            sqldata.Fill(dtlb);
            dataGridView1.DataSource = dtlb;
            con.Close();
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
