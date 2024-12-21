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
    public partial class Loginfrm : Form
    {
        public static string usernamepassing;
        public static string passwordpassing;
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registercusfrm form = new Registercusfrm();
            form.Show();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            passwordpassing = textBoxpassword.Text;
            usernamepassing = textBoxusername.Text;
            user ob1 = new user(textBoxusername.Text,textBoxpassword.Text);
            string status;
            status =ob1.login(textBoxusername.Text);
            if (status != null) MessageBox.Show(status);
            textBoxusername.Text = string.Empty;
            textBoxpassword.Text = string.Empty;
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
