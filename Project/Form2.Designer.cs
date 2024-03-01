namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.stockbtn = new System.Windows.Forms.Button();
            this.financebtn = new System.Windows.Forms.Button();
            this.manageusersbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.dashboard1 = new Project.Dashboard();
            this.finance1 = new Project.Finance();
            this.manageUsers1 = new Project.ManageUsers();
            this.stock1 = new Project.Stock();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.stockbtn);
            this.panel1.Controls.Add(this.financebtn);
            this.panel1.Controls.Add(this.manageusersbtn);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Location = new System.Drawing.Point(-3, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 745);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project.Properties.Resources.output_onlinepngtools__6_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Project.Properties.Resources.output_onlinepngtools__5_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(3, 167);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 38);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project.Properties.Resources.output_onlinepngtools__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project.Properties.Resources.output_onlinepngtools__4_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(15, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 36);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // stockbtn
            // 
            this.stockbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.stockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockbtn.FlatAppearance.BorderSize = 0;
            this.stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockbtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockbtn.ForeColor = System.Drawing.Color.Transparent;
            this.stockbtn.Location = new System.Drawing.Point(0, 167);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Size = new System.Drawing.Size(277, 38);
            this.stockbtn.TabIndex = 5;
            this.stockbtn.Text = "Stock";
            this.stockbtn.UseVisualStyleBackColor = false;
            this.stockbtn.Click += new System.EventHandler(this.stockbtn_Click);
            this.stockbtn.MouseHover += new System.EventHandler(this.stockbtn_MouseHover);
            // 
            // financebtn
            // 
            this.financebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.financebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.financebtn.FlatAppearance.BorderSize = 0;
            this.financebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financebtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financebtn.ForeColor = System.Drawing.Color.Transparent;
            this.financebtn.Location = new System.Drawing.Point(0, 223);
            this.financebtn.Name = "financebtn";
            this.financebtn.Size = new System.Drawing.Size(277, 38);
            this.financebtn.TabIndex = 4;
            this.financebtn.Text = "Finance";
            this.financebtn.UseVisualStyleBackColor = false;
            this.financebtn.Click += new System.EventHandler(this.financebtn_Click);
            this.financebtn.MouseHover += new System.EventHandler(this.financebtn_MouseHover);
            // 
            // manageusersbtn
            // 
            this.manageusersbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.manageusersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageusersbtn.FlatAppearance.BorderSize = 0;
            this.manageusersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageusersbtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageusersbtn.ForeColor = System.Drawing.Color.Transparent;
            this.manageusersbtn.Location = new System.Drawing.Point(0, 106);
            this.manageusersbtn.Name = "manageusersbtn";
            this.manageusersbtn.Size = new System.Drawing.Size(277, 38);
            this.manageusersbtn.TabIndex = 6;
            this.manageusersbtn.Text = "Manage users";
            this.manageusersbtn.UseVisualStyleBackColor = false;
            this.manageusersbtn.Click += new System.EventHandler(this.manageusersbtn_Click);
            this.manageusersbtn.MouseHover += new System.EventHandler(this.manageusersbtn_MouseHover);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.dashboardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardbtn.FlatAppearance.BorderSize = 0;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.Color.Transparent;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 45);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(277, 38);
            this.dashboardbtn.TabIndex = 3;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            this.dashboardbtn.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.LogOutBtn);
            this.panel2.Controls.Add(this.labelWelcome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica CondensedBlack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dashboard1);
            this.panelContainer.Controls.Add(this.finance1);
            this.panelContainer.Controls.Add(this.manageUsers1);
            this.panelContainer.Controls.Add(this.stock1);
            this.panelContainer.Location = new System.Drawing.Point(280, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1124, 704);
            this.panelContainer.TabIndex = 3;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica CE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(932, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Helvetica CE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(1038, 49);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(100, 24);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutBtn.BackColor = System.Drawing.Color.Maroon;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutBtn.Font = new System.Drawing.Font("Helvetica CE", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutBtn.Location = new System.Drawing.Point(1172, 42);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(91, 35);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(-42, 3);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1166, 701);
            this.dashboard1.TabIndex = 3;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // finance1
            // 
            this.finance1.Location = new System.Drawing.Point(3, 3);
            this.finance1.Name = "finance1";
            this.finance1.Size = new System.Drawing.Size(1124, 701);
            this.finance1.TabIndex = 2;
            // 
            // manageUsers1
            // 
            this.manageUsers1.Location = new System.Drawing.Point(15, 16);
            this.manageUsers1.Name = "manageUsers1";
            this.manageUsers1.Size = new System.Drawing.Size(1124, 701);
            this.manageUsers1.TabIndex = 1;
            // 
            // stock1
            // 
            this.stock1.Location = new System.Drawing.Point(12, 16);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(1124, 701);
            this.stock1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 822);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.Button financebtn;
        private System.Windows.Forms.Button manageusersbtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panelContainer;
        private Finance finance1;
        private ManageUsers manageUsers1;
        private Stock stock1;
        private Dashboard dashboard1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label label2;
    }
}