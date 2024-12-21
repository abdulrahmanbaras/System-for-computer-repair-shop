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
    internal class Register
    {
        private string name;
        private string email;
        private string username;
        private string password;
        private string confpass;
        private string number;
        private string newusername;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Number { get => number; set => number = value; }
        public string Password { get => password; set => password = value; }

        public Register(string n, string em, string un, string p, string cp, string num)
        {
            name = n;
            email = em;
            username = un;
            password = p;
            confpass = cp;
            number = num;

        }
        public Register(string un)
        {
            username = un;
        }
        public Register(string un,string nun)
        {
            username = un;
            newusername = nun;
        }
        public string recepreg()
        {
            string stat;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into receptionists(name,email,number,password,username) values(@name,@em,@num,@pass,@usn)", con);
            SqlCommand cmd2 = new SqlCommand("insert into users(username,password,role) values(@usn,@pass,'receptionist')", con);
            SqlCommand cmd4 = new SqlCommand("select count(*) from users where username='" + username + "'", con);
            int count = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
            if ((confpass != "") && (password != "") && (name != "") && (email != "") && (username != "") && (number != ""))
            {
                if (password == confpass)
                {
                    if (namevalidation(name))
                    {
                        if (emailvalidation(email))
                        {
                            if (usernamevalidation(username))
                            {
                                if (numbervalidation(number))
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
                                        cmd2.Parameters.AddWithValue("@usn", username);
                                        cmd.Parameters.AddWithValue("@pass", password);
                                        cmd2.Parameters.AddWithValue("@pass", password);
                                        cmd.Parameters.AddWithValue("@num", number);
                                        cmd2.ExecuteNonQuery();
                                        int row = cmd.ExecuteNonQuery();
                                        if (row != 0) stat = "registeration successful";
                                        else stat = "enable to register";
                                    }

                                }
                                else stat = "phone number not valid";
                            }
                            else stat = "username not valid";
                        }
                        else stat = "email not valid";
                    }
                    else stat = "name not valid";

                }
                else stat = "password doesn't match";
            }
            else stat = "all informations should be entered";
            con.Close();
            return stat;
        }
        public string techreg()
        {
            string stat;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tech(name,email,number,password,username) values(@name,@em,@num,@pass,@usn)", con);
            SqlCommand cmd2 = new SqlCommand("insert into users(username,password,role) values(@usn,@pass,'technician')", con);
            SqlCommand cmd4 = new SqlCommand("select count(*) from users where username='" + username + "'", con);
            int count = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
            if ((confpass != "") && (password != "") && (name != "") && (email != "") && (username != "") && (number != ""))
            {
                if (password == confpass)
                {
                    if (namevalidation(name))
                    {
                        if (emailvalidation(email))
                        {
                            if (usernamevalidation(username))
                            {
                                if (numbervalidation(number))
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
                                        cmd2.Parameters.AddWithValue("@usn", username);
                                        cmd.Parameters.AddWithValue("@pass", password);
                                        cmd2.Parameters.AddWithValue("@pass", password);
                                        cmd.Parameters.AddWithValue("@num", number);
                                        cmd2.ExecuteNonQuery();
                                        int row = cmd.ExecuteNonQuery();
                                        if (row != 0) stat = "registeration successful";
                                        else stat = "enable to register";
                                    }


                                }
                                else stat = "phone number not valid";
                            }
                            else stat = "username not valid";
                        }
                        else stat = "email not valid";
                    }
                    else stat = "name not valid";

                }
                else stat = "password doesn't match";
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
        public string userupdate()
        {
            string stat;
            string role;
            con.Open();
            SqlCommand cmd = new SqlCommand("select role from users where username='" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                role = rd.GetString(0);
                con.Close();

                if (role == "receptionist")
                {

                    if (usernamevalidation(newusername))
                    {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("Update users set username ='" + newusername + "' where username ='" + username + "'", con);

                        SqlCommand cmd3 = new SqlCommand("Update receptionists set username ='" + newusername + "' where username ='" + username + "'", con);
                        cmd2.ExecuteNonQuery();
                        int row = cmd3.ExecuteNonQuery();
                        if (row != 0) stat = "Update successful";
                        else stat = "enable to update";
                        con.Close();
                    }
                    else stat = "invalid username";

                }

                else if (role == "customer")
                {
                    if (usernamevalidation(newusername))
                    {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("Update users set username ='" + newusername + "' where username ='" + username + "'", con);

                        SqlCommand cmd3 = new SqlCommand("Update customer set username ='" + newusername + "' where username ='" + username + "'", con);
                        cmd2.ExecuteNonQuery();
                        int row = cmd3.ExecuteNonQuery();
                        if (row != 0) stat = "Update successful";
                        else stat = "enable to update";
                        con.Close();
                    }
                    else stat = "invalid username";
                }
                else if (role == "technician")
                {
                    if (usernamevalidation(newusername))
                    {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("Update users set username ='" + newusername + "' where username ='" + username + "'", con);

                        SqlCommand cmd3 = new SqlCommand("Update tech set username ='" + newusername + "' where username ='" + username + "'", con);
                        cmd2.ExecuteNonQuery();
                        int row = cmd3.ExecuteNonQuery();
                        if (row != 0) stat = "Update successful";
                        else stat = "enable to update";
                        con.Close();
                    }
                    else stat = "invalid username";
                }
                else stat = "This account can not be updated";

            }
            else stat = "sorry this username does not exist";
            con.Close();
            return stat;

        }
            
        
    }
}

 
