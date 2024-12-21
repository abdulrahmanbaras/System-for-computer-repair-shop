using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storybored
{
    public partial class Registercusfrm : Form
    {
        public Registercusfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxserv.Text == "Remove virus, malware or spyware" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "50";
            }
            else if (listBoxserv.Text == "Remove virus, malware or spyware" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "80";
            }
            else if (listBoxserv.Text == "Troubleshot and fix computer running slow" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "60";
            }
            else if (listBoxserv.Text == "Troubleshot and fix computer running slow" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "90";
            }
            else if (listBoxserv.Text == "Laptop screen replacement" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "380";
            }
            else if (listBoxserv.Text == "Laptop screen replacement" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "430";
            }
            else if (listBoxserv.Text == "Laptop keyboard replacement" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "160";
            }
            else if (listBoxserv.Text == "Laptop keyboard replacement" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "200";
            }
            else if (listBoxserv.Text == "Laptop battery replacement" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "180";
            }
            else if (listBoxserv.Text == "Laptop battery replacement" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "210";
            }
            else if (listBoxserv.Text == "Operating System Format and Installation" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "100";
            }
            else if (listBoxserv.Text == "Operating System Format and Installation" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "150";
            }
            else if (listBoxserv.Text == "Data backup and recovery" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "80";
            }
            else if (listBoxserv.Text == "Data backup and recovery" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "130";
            }
            else if (listBoxserv.Text == "Internet connectivity issues" && listBoxsertyp.Text == "Normal")
            {
                lblprice.Text = "70";
            }
            else if (listBoxserv.Text == "Internet connectivity issues" && listBoxsertyp.Text == "Urgent")
            {
                lblprice.Text = "100";
            }
            if ((comboBoxdd.SelectedIndex > -1) && (comboBoxyear.SelectedIndex > -1) && (comboBoxmonth.SelectedIndex > -1))
            {
                customer ob1 = new customer(textBoxname.Text, textBoxemail.Text, textBoxusername.Text, textBoxpassword.Text, lblprice.Text, textBoxnum.Text, listBoxserv.Text, listBoxsertyp.Text, comboBoxmonth.Text);
                MessageBox.Show(ob1.Registercust());
            }
            else MessageBox.Show("please select date");
            
        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Registercusfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
