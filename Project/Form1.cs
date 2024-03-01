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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Project
{
    public partial class Form1 : Form
    {
        LogIn login;

        public Form1()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '●';
            emailValidityLabel.Hide();
            Fullscreen();
            DBConnect.connectDB();
            dbStatus();
            DBConnect.closeConnection();
        }

        public void Fullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }


        public void dbStatus()
        {
            if (DBConnect.connection != null && DBConnect.connection.State == ConnectionState.Closed)

            {
                statusDB.Text = "NOT CONNECTED";
                statusDB.ForeColor = Color.Red;
            }
            else
            {
                statusDB.Text = "CONNECTED";
                statusDB.ForeColor = Color.Green;
               
            }
        }

        public void validate()
        {
            
            login = new LogIn();
            if (login.checkUsername() == false)
            {
                emailValidityLabel.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate();
            validate_id();
            

        }

        private void validate_id () 
        {
            int userType = login.id_type;
           
            switch (userType)
            {
                case 1:
                    this.Hide();
                    Form2 form2 = new Form2();
                    emailTextBox.Clear();
                    passwordTextBox.Clear();
                    form2.Show();
                    break;
                case 2:
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                    break;
                default:
                    break;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
