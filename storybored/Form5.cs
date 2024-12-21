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
    public partial class Admin_page : Form
    {
        public static string name;
        public Admin_page()
        {
            InitializeComponent();
        }
        public Admin_page(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void Admin_page_Load(object sender, EventArgs e)
        {
            lblwellcome.Text = "wellcome " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rgstech r = new rgstech();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmregrecep r = new frmregrecep();
            r.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmreport r = new frmreport();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
    }
}
