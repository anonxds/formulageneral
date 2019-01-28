using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;

namespace formulageneral
{
    public partial class Form1 : Form
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter db;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        
        private void setcon()
        {
            con = new SQLiteConnection("Data Source=registros.sqlite3;Version=3;New=False;Compress=true;");
        }
        private void Exe(string query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void loaddata()
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            string cmdt = "select * from datos";
            db = new SQLiteDataAdapter(cmdt, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            con.Close();
        }
       
        private void btnresolver_Click(object sender, EventArgs e)
        {
            try
            {
                
              
                double a, b, c, x1, x2;
                int id=0;
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);

               


                x1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                x2 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                lblresultado.Text = "X1= " + x1.ToString();
                lblx2.Text = "X2 = " + x2.ToString();

                /*
                string query = @"INSERT INTO datos ( 'id' , 'fecha' , 'A' , 'B' , 'C' , 'x1' , 'x2' ) VALUES (@id,@fecha,@A,@B,@C,@x1,@x2)";
            
               
                cmd.Parameters.AddWithValue("@fecha", );
                cmd.Parameters.AddWithValue("@A", txta.Text);
                cmd.Parameters.AddWithValue("@B", txtb.Text);
                cmd.Parameters.AddWithValue("@C", txtc.Text);
          
                cmd.Parameters.AddWithValue("@x1", lblresultado.Text);
                cmd.Parameters.AddWithValue("@x2", lblx2.Text);
                */
              
                string query = string.Format("insert into datos values ('{0}','{1}','{2}','{3}','{4}','{5}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txta.Text, txtb.Text, txtc.Text, lblresultado.Text, lblx2.Text);
                Exe(query);
            
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor llene toda la informacion"+ ex);
            }
        }

        public Form1()
        {
            InitializeComponent();
            loaddata();
            

       
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
