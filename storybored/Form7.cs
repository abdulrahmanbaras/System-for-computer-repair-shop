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
    public partial class frmregrecep : Form
    {
        public frmregrecep()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Register ob1 = new Register(textBoxname.Text,textBoxemail.Text,textBoxusername.Text,textBoxpassword.Text,textBoxCpassword.Text,textBoxnumber.Text);
            MessageBox.Show(ob1.recepreg());
        }

        private void textBoxnumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
