using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddUser : UserControl
    {
        SQLoperations operations;
        public string name;
        public string lastname;
        public string email;
        public string password;
        public string type;
        public AddUser()
        {
            InitializeComponent();
            operations = new SQLoperations();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addUserbtn_MouseEnter(object sender, EventArgs e)
        {
        }

        private void addUserbtn_MouseHover(object sender, EventArgs e)
        {
            addUserbtn.BackColor = Color.Green;
        }

        private void addUserbtn_MouseLeave(object sender, EventArgs e)
        {
            addUserbtn.BackColor = Color.White;
        }

        private void addUserbtn_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            lastname = lastnameTextBox.Text;
            email = emailTextBox.Text;  
            password = PasswordTextBox.Text;
            if(typeComboBox.SelectedItem != null && name != "" && lastname != "" && email != "" && password != "") { 
            
                string typeString = typeComboBox.SelectedItem.ToString();
                int type = operations.ConvertUserType(typeString);
                operations.AddNewUser(name, lastname, email, password, type);
                Visible = false;
            }
            else
            {
                MessageBox.Show("Fill out all the fields, please...");
            }
            
        }

        private void closeAddBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
