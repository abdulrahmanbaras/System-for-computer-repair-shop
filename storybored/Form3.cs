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
    public partial class receptionist_page : Form
    {
        public static string name;
        public receptionist_page()
        {
            InitializeComponent();
        }
        public receptionist_page(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void receptionist_page_Load(object sender, EventArgs e)
        {
            lblwellcome.Text = "wellcome " + name;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registercusfrm r = new Registercusfrm();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmpayment f = new frmpayment();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 page = new Form13();
            page.ShowDialog();
        }
    }
}
