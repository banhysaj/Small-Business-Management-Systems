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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form2 : Form
    {
        LogIn login = new LogIn();
        public int id;
        SQLoperations operation = new SQLoperations();
        public Form2()
        {
            InitializeComponent();
            Fullscreen();
            id = login.getLogin();
            Load += Form2_Load;
            stock1.passID.Value = id;
            displayLogIn();
        }

        public void displayLogIn()
        {
            string name = operation.getName(id);
            labelWelcome.Text = name;
        }

        public void Fullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            dashboardbtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void manageusersbtn_MouseHover(object sender, EventArgs e)
        {
            manageusersbtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void stockbtn_MouseHover(object sender, EventArgs e)
        {
            stockbtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void financebtn_MouseHover(object sender, EventArgs e)
        {
            financebtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
        }

        private void manageusersbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(manageUsers1);
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(stock1);
        }

        private void financebtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(finance1);
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
        public void SetActivePanel(UserControl control)
        {
            dashboard1.Visible = false;
            manageUsers1.Visible = false;
            stock1.Visible = false;
            finance1.Visible = false;

            control.Visible = true;

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
        }
    }
}
