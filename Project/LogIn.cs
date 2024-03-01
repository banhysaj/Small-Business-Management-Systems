using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace Project
{
    internal class LogIn 
    {
        string query;
        public int id_type;
        string emails;
        string passwords;
        Form1 form1 = (Form1)Application.OpenForms["Form1"];
        

        public LogIn()
        {
        }

        public bool checkUsername()
        {
            query = "SELECT email, password, id_type FROM user";
            DBConnect.connectDB();
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            if (!(IsValidEmail(form1.emailTextBox.Text)))
            {
                reader.Close();
                DBConnect.closeConnection();
                return false;
            }
            else
            {
                    while (reader.Read())
                    {
                   
                        emails = reader["email"].ToString();
                              if (string.Equals(form1.emailTextBox.Text, emails, StringComparison.OrdinalIgnoreCase))
                              {
                                    passwords = reader["password"].ToString();
                                    if(string.Equals(form1.passwordTextBox.Text, passwords))
                                    {
                                        id_type = Convert.ToInt32(reader["id_type"]); 
                                        reader.Close();
                                        DBConnect.closeConnection();    
                                        return true;
                                    }
                              }
                    }
                reader.Close();
                DBConnect.closeConnection();
            }
            return false;
        }

        public int getLogin()
        {
            query = "SELECT email, id FROM user";
            int id = 0;
            DBConnect.connectDB();
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            if (!(IsValidEmail(form1.emailTextBox.Text)))
            {
                reader.Close();
            }
            else
            {
                while (reader.Read())
                {

                    string emails = reader["email"].ToString();
                     
                    if (string.Equals(form1.emailTextBox.Text, emails, StringComparison.OrdinalIgnoreCase))
                    {   
                         id = reader.GetInt32("id");
                    }
                }
                reader.Close();

            }
            DBConnect.closeConnection();
            return id;
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                if(email == "")
                {
                    return false;
                }
                else
                {
                    MailAddress mailAddress = new MailAddress(email);
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }




    }
}
