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
using System.Collections;
using System.Drawing.Printing;


namespace Project
{
    public partial class Dashboard : UserControl
    {

        List<String> names;
        SQLoperations operations;

        public Dashboard()
        {
            InitializeComponent();
            names = new List<String>(); 
            operations = new SQLoperations();   
            displayNrOfUsers();
            displayNrOfStock();
            DBConnect.closeConnection();
            
        }

        public void displayNrOfStock()
        {
            int stockNr = operations.totalProducts();
            label7.Text = stockNr.ToString();
        }


        public int countUsers()
        {
            int totalNumber;
            names = operations.totalUsers();
            totalNumber = names.Count();
            return totalNumber; 
        }

        public void displayNrOfUsers()
        {
            int userCount = countUsers();
            userNumber.Text = userCount.ToString();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.profitlabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.productslabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.saleslabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userNumber = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.userslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 695);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(622, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 226);
            this.panel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "13000 ALL";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.panel9.Controls.Add(this.profitlabel);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(351, 53);
            this.panel9.TabIndex = 7;
            // 
            // profitlabel
            // 
            this.profitlabel.AutoSize = true;
            this.profitlabel.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitlabel.Location = new System.Drawing.Point(148, 13);
            this.profitlabel.Name = "profitlabel";
            this.profitlabel.Size = new System.Drawing.Size(62, 26);
            this.profitlabel.TabIndex = 5;
            this.profitlabel.Text = "Profit";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Location = new System.Drawing.Point(144, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 226);
            this.panel4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(109, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Products in Stock";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.panel10.Controls.Add(this.productslabel);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(350, 53);
            this.panel10.TabIndex = 7;
            // 
            // productslabel
            // 
            this.productslabel.AutoSize = true;
            this.productslabel.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productslabel.Location = new System.Drawing.Point(130, 13);
            this.productslabel.Name = "productslabel";
            this.productslabel.Size = new System.Drawing.Size(91, 26);
            this.productslabel.TabIndex = 4;
            this.productslabel.Text = "Products";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(622, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 226);
            this.panel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "31";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Orders today";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.panel8.Controls.Add(this.saleslabel);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(351, 53);
            this.panel8.TabIndex = 7;
            // 
            // saleslabel
            // 
            this.saleslabel.AutoSize = true;
            this.saleslabel.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleslabel.Location = new System.Drawing.Point(150, 13);
            this.saleslabel.Name = "saleslabel";
            this.saleslabel.Size = new System.Drawing.Size(60, 26);
            this.saleslabel.TabIndex = 4;
            this.saleslabel.Text = "Sales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.userNumber);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(144, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 226);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Users registered in the system";
            // 
            // userNumber
            // 
            this.userNumber.AutoSize = true;
            this.userNumber.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumber.Location = new System.Drawing.Point(166, 100);
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(19, 26);
            this.userNumber.TabIndex = 7;
            this.userNumber.Text = ".";
            this.userNumber.Click += new System.EventHandler(this.userNumber_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.panel7.Controls.Add(this.userslabel);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 53);
            this.panel7.TabIndex = 6;
            // 
            // userslabel
            // 
            this.userslabel.AutoSize = true;
            this.userslabel.Font = new System.Drawing.Font("Helvetica CondensedBlack", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userslabel.Location = new System.Drawing.Point(140, 13);
            this.userslabel.Name = "userslabel";
            this.userslabel.Size = new System.Drawing.Size(60, 26);
            this.userslabel.TabIndex = 2;
            this.userslabel.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica CondensedBlack", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(138, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Analytics";
            // 
            // Dashboard
            // 
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1124, 701);
            this.Load += new System.EventHandler(this.Dashboard_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
