using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace storybored
{
    class customer
    {
        private string username;
        private string name;
        private string email;
        private string phone;
        private string password;
        private string price;
        private string service;
        private string servicetyp;
        private string fees;
        private string month;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username { get => username; set => username = value; }

        public customer(string n, string em, string un, string p, string pr, string num, string ser, string sertyp,string mo)
        {
            name = n;
            email = em;
            username = un;
            password = p;
            price = pr;
            phone = num;
            service = ser;
            servicetyp = sertyp;
            month = mo;

        }
        public customer(string un,string fe)
        {
            username = un;
            fees = fe;
        }
        public string Registercust()
        {
            string stat;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer(username,name,email,Phone) values(@usn,@name,@em,@num)", con);
            SqlCommand cmd2 = new SqlCommand("insert into users(username,password,role) values(@usn,@pass,'customer')", con);
            SqlCommand cmd3 = new SqlCommand("insert into services(service,username,type,paid,price,month) values(@sr,@usn,@tp,'0',@prs,@mon)", con);
            SqlCommand cmd4 = new SqlCommand("select count(*) from users where username='" + username + "'", con);
            int count = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
            if ((password != "") && (name != "") && (email != "") && (username != "") && (phone != "") && (service != "") && (servicetyp != ""))
            {
                if (count > 0)
                {
                    stat = "username already exist";
                }
                else
                {
                    if (usernamevalidation(username))
                    {
                        if (namevalidation(name))
                        {
                            if (numbervalidation(phone))
                            {
                                if (emailvalidation(email))
                                {
                                    if (count > 0)
                                    {
                                        stat = "username already exist";
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@name", name);
                                        cmd.Parameters.AddWithValue("@em", email);
                                        cmd.Parameters.AddWithValue("@usn", username);
                                        cmd.Parameters.AddWithValue("@num", phone);
                                        cmd2.Parameters.AddWithValue("@usn", username);
                                        cmd2.Parameters.AddWithValue("@pass", password);
                                        cmd3.Parameters.AddWithValue("@sr", service);
                                        cmd3.Parameters.AddWithValue("@usn", username);
                                        cmd3.Parameters.AddWithValue("@tp", servicetyp);
                                        cmd3.Parameters.AddWithValue("@prs", price);
                                        cmd3.Parameters.AddWithValue("@mon",month);
                                        cmd2.ExecuteNonQuery();
                                        cmd3.ExecuteNonQuery();
                                        int row = cmd.ExecuteNonQuery();
                                        if (row != 0) stat = "registeration successful";
                                        else stat = "enable to register";
                                    }
                                }
                                else stat = "email not valid";
                            }
                            else stat = "phone number not valid";
                        }
                        else stat = "name not valid";
                    }
                    else stat = "username not valid";

                }

            }
            else stat = "all informations should be entered";
            con.Close();
            return stat;
        }
        public bool emailvalidation(string em)
        {
            const string pattern = "^[A-Za-z0-9]{2,20}" + @"@[A-Za-z]{3,10}\." + "[a-zA-z]{2,10}$";
            Regex val = new Regex(pattern);
            return val.IsMatch(em);
        }
        public bool namevalidation(string n)
        {
            const string pattern = "^[A-Za-z]{2,30}$";
            Regex val = new Regex(pattern);
            return val.IsMatch(n);
        }
        public bool usernamevalidation(string n)
        {
            const string pattern = "^[A-Za-z0-9_]{2,30}$";
            Regex val = new Regex(pattern);
            return val.IsMatch(n);
        }
        public bool numbervalidation(string n)
        {
            const string pattern = "^01[0-9]{8}$";
            Regex val = new Regex(pattern);
            return val.IsMatch(n);

        }

        public string addpayment()
        {
            string stat;
            con.Open();
            SqlCommand cmd = new SqlCommand("Update services set paid ='" + fees + "' where username ='" + username + "'", con);
            int row = cmd.ExecuteNonQuery();
            if (row != 0) stat = "payment successful";
            else stat = "enable to pay";
            con.Close();
            return stat;
        }
        
    
        
    }
}
