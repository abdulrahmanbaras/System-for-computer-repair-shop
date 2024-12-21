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
    public partial class Form13 : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Form13()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            
            Register obj = new Register(textBoxnewpassword.Text);
            if (textBoxcurrpassword.Text == Loginfrm.passwordpassing)
            {
                if ((textBoxconfpassword.Text == textBoxnewpassword.Text) &&(textBoxnewpassword.Text!=""))
                {
                    string role;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select role from users where username='" + Loginfrm.usernamepassing + "'", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        role = rd.GetString(0);
                        con.Close();
                        if (role == "receptionist")
                        {
                            
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("Update users set password ='" + textBoxnewpassword.Text + "' where username ='" + Loginfrm.usernamepassing + "'", con);

                            SqlCommand cmd3 = new SqlCommand("Update receptionists set password ='" + textBoxnewpassword.Text + "' where username ='" + Loginfrm.usernamepassing + "'", con);
                            cmd2.ExecuteNonQuery();
                            int row = cmd3.ExecuteNonQuery();
                            if (row != 0) MessageBox.Show("Update successful");
                            else MessageBox.Show("enable to update");
                            con.Close();
                            
                        }
                        else if (role == "customer")
                        {
                            
                            
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("Update users set password ='" + textBoxnewpassword.Text + "' where username ='" + Loginfrm.usernamepassing + "'", con);

                            SqlCommand cmd3 = new SqlCommand("Update customer set password ='" + textBoxnewpassword.Text + "' where username ='" + Loginfrm.usernamepassing + "'", con);
                            cmd2.ExecuteNonQuery();
                            int row = cmd3.ExecuteNonQuery();
                            if (row != 0) MessageBox.Show("Update successful");
                            else MessageBox.Show("enable to update");
                            con.Close();
                            
                            
                        }
                        else if (role == "technician")
                        {
                            
                            
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("Update users set password ='" + textBoxnewpassword.Text + "' where username ='" + Loginfrm.usernamepassing + "'", con);

                            SqlCommand cmd3 = new SqlCommand("Update tech set password ='" + textBoxnewpassword.Text + "' where username ='" + Loginfrm.usernamepassing + "'", con);
                            cmd2.ExecuteNonQuery();
                            int row = cmd3.ExecuteNonQuery();
                            if (row != 0) MessageBox.Show("Update successful");
                            else MessageBox.Show("enable to update");
                            con.Close();
                            
                            
                        }

                    }
                    else MessageBox.Show("sorry this username does not exist");
                }
                else MessageBox.Show("pssword does not match");
                
            
            }
            else MessageBox.Show("please inter your correct password");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
