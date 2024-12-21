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
    public partial class technician_page : Form
    {
        public static string name;

        public technician_page()
        {
            InitializeComponent();
        }
        public technician_page(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 page = new Form4();
            page.ShowDialog();
        }

        private void technician_page_Load(object sender, EventArgs e)
        {
            lblwellcome.Text = "wellcome " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 page = new Form13();
            page.ShowDialog();
        }
    }
}
