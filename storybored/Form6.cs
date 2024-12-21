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
    public partial class rgstech : Form
    {
        public rgstech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register ob1 = new Register(textBoxname.Text, textBoxemail.Text, textBoxusername.Text, textBoxpassword.Text, textBoxCpassword.Text, textBoxnumber.Text);
            MessageBox.Show(ob1.techreg());
        }

        private void textBoxnumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rgstech_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
