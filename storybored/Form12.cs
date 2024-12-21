using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace storybored
{
    public partial class frmpayment : Form
    {
        public static string usnm;
        public frmpayment()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select price from services where username='" + textBox1.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show(rd.GetInt32(0).ToString());
            }
            else MessageBox.Show("username cannote be found");








        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer ob = new customer(textBox1.Text, textBoxpay.Text);
            MessageBox.Show(ob.addpayment());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select price,service,type,paid from services where username='" + textBox1.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                richTextBox1.Text = "######   G33 Laptop Repair Shop   ######\n\n";
                richTextBox1.Text += "----------------------------------------------------------\n\n";
                richTextBox1.Text += "  chosen service: "+rd.GetString(1)+ "\n\n";
                richTextBox1.Text += "----------------------------------------------------------\n\n";
                richTextBox1.Text += "  service type: "+rd.GetString(2) + "\n\n";
                richTextBox1.Text += "----------------------------------------------------------\n\n";
                richTextBox1.Text += "  Total Amount to pay: " + rd.GetInt32(0).ToString() + "\n\n";
                richTextBox1.Text += "----------------------------------------------------------\n\n";
                richTextBox1.Text += "  Total paid amount: "+rd.GetInt32(3).ToString() + "\n\n";
                richTextBox1.Text += "----------------------------------------------------------\n";
                richTextBox1.Text += "##############  G  #############\n##############  3  #############\n##############  3  #############";


            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
