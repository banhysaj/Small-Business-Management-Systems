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
    public partial class ManageUsers : UserControl
    {   
 
        SQLoperations SQLoperations;
        public string name;
        public string lastname;
        public string email;
        public string password;
        public string type;
        public string oldEmail;
        public ManageUsers()
        {
            InitializeComponent();
            SQLoperations = new SQLoperations();
            addUser1.Visible = false;
            panelUpdateUser.Visible = false;
            populateTable();
        }

        public void populateTable()
        {
            
            dataGridViewNames.AutoGenerateColumns = false;
            BindingList<Person> data = SQLoperations.getPerson();
            BindingSource bindingsource = new BindingSource();
            bindingsource.DataSource = data;     
            dataGridViewNames.AutoGenerateColumns = true;
            dataGridViewNames.DataSource = bindingsource;
            dataGridViewNames.Columns["ID"].Visible = false;
            
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUser1.Visible = true;
        }

        private void dataGridViewNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewNames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewNames.SelectedRows.Count > 0)
            {
                
                nameTextBox.Text = dataGridViewNames.SelectedRows[0].Cells[1].Value.ToString();
                lastnameTextBox.Text = dataGridViewNames.SelectedRows[0].Cells[2].Value.ToString();
                emailTextBox.Text = dataGridViewNames.SelectedRows[0].Cells[3].Value.ToString();
                oldEmail = emailTextBox.Text;
                PasswordTextBox.Text = dataGridViewNames.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void updateUserbtn_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewNames.SelectedRows[0].Cells[0].Value;
            name = nameTextBox.Text;
            lastname = lastnameTextBox.Text;
            email = emailTextBox.Text;
            password = PasswordTextBox.Text;
            if (name != "" && lastname != "" && email != "" && password != "") 
            {
                SQLoperations.UpdateSelectedUser(id, name, lastname, email, password);
                populateTable();
            }
            else
            {
                MessageBox.Show("Please fill out all the fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Visible = true;

        }

        private void closeUpdateBtn_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Visible=false;
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            SQLoperations.deleteUser((int)dataGridViewNames.SelectedRows[0].Cells[0].Value);
            populateTable();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            populateTable();
        }
    }
}
