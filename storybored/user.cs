using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace storybored
{
    internal class user
    {
        private string username;
        private string password;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public user(string u,string p)
        {
            username = u;
            password = p;
        }
        public string login(string un)
        {
            string stat = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from users where username='" + username + "'and password='" + password + "'", con);
            int count=Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username='" + username + "'and password='" + password + "'", con);
                string userole=cmd2.ExecuteScalar().ToString();
                if (userole == "admin")
                {
                    Admin_page page=new Admin_page(un);
                    page.ShowDialog();
                }
                else if (userole == "receptionist")
                {
                    receptionist_page page = new receptionist_page(un);
                    page.ShowDialog();
                }
                else if (userole == "technician")
                {
                    technician_page page = new technician_page(un);
                    page.ShowDialog();
                }

            }
            else
                stat = "incorrect username/password";
            con.Close();
            return stat;

        }

    }
}
