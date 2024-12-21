using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace storybored
{
    public partial class frmreport : Form
    {
        public frmreport()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private void btnreport_Click(object sender, EventArgs e)

        {
            if (comboBox1.SelectedIndex > -1)
            {
                string Month = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("select * from services where month='" + Month + "'", con);
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                a.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\almanar\source\repos\storybored\storybored\Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();

            }
            else MessageBox.Show("please select month");


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
