namespace Project
{
    partial class ManageUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewNames = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panelUpdateUser = new System.Windows.Forms.Panel();
            this.closeUpdateBtn = new System.Windows.Forms.Button();
            this.updateUserbtn = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addUser1 = new Project.AddUser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNames)).BeginInit();
            this.panelUpdateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica CondensedBlack", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Users";
            // 
            // dataGridViewNames
            // 
            this.dataGridViewNames.AllowUserToOrderColumns = true;
            this.dataGridViewNames.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewNames.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNames.Location = new System.Drawing.Point(25, 105);
            this.dataGridViewNames.Name = "dataGridViewNames";
            this.dataGridViewNames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNames.Size = new System.Drawing.Size(785, 505);
            this.dataGridViewNames.TabIndex = 2;
            this.dataGridViewNames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNames_CellClick);
            this.dataGridViewNames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNames_CellContentClick);
            this.dataGridViewNames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewNames_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(176)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Helvetica CondensedLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(252)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Helvetica CondensedLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(427, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // panelUpdateUser
            // 
            this.panelUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpdateUser.Controls.Add(this.closeUpdateBtn);
            this.panelUpdateUser.Controls.Add(this.updateUserbtn);
            this.panelUpdateUser.Controls.Add(this.passwordlabel);
            this.panelUpdateUser.Controls.Add(this.PasswordTextBox);
            this.panelUpdateUser.Controls.Add(this.lastnameTextBox);
            this.panelUpdateUser.Controls.Add(this.emailTextBox);
            this.panelUpdateUser.Controls.Add(this.nameTextBox);
            this.panelUpdateUser.Controls.Add(this.label3);
            this.panelUpdateUser.Controls.Add(this.label1);
            this.panelUpdateUser.Controls.Add(this.label5);
            this.panelUpdateUser.Location = new System.Drawing.Point(816, 178);
            this.panelUpdateUser.Name = "panelUpdateUser";
            this.panelUpdateUser.Size = new System.Drawing.Size(279, 364);
            this.panelUpdateUser.TabIndex = 8;
            // 
            // closeUpdateBtn
            // 
            this.closeUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.closeUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeUpdateBtn.Location = new System.Drawing.Point(232, 15);
            this.closeUpdateBtn.Name = "closeUpdateBtn";
            this.closeUpdateBtn.Size = new System.Drawing.Size(25, 26);
            this.closeUpdateBtn.TabIndex = 33;
            this.closeUpdateBtn.Text = "X";
            this.closeUpdateBtn.UseVisualStyleBackColor = false;
            this.closeUpdateBtn.Click += new System.EventHandler(this.closeUpdateBtn_Click);
            // 
            // updateUserbtn
            // 
            this.updateUserbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(176)))));
            this.updateUserbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateUserbtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserbtn.Location = new System.Drawing.Point(95, 260);
            this.updateUserbtn.Name = "updateUserbtn";
            this.updateUserbtn.Size = new System.Drawing.Size(75, 23);
            this.updateUserbtn.TabIndex = 32;
            this.updateUserbtn.Text = "Update";
            this.updateUserbtn.UseVisualStyleBackColor = false;
            this.updateUserbtn.Click += new System.EventHandler(this.updateUserbtn_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(55, 188);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(52, 16);
            this.passwordlabel.TabIndex = 31;
            this.passwordlabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(58, 207);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(162, 24);
            this.PasswordTextBox.TabIndex = 30;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextBox.Location = new System.Drawing.Point(58, 105);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(162, 24);
            this.lastnameTextBox.TabIndex = 28;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(58, 153);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(162, 24);
            this.emailTextBox.TabIndex = 27;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(58, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 24);
            this.nameTextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.deleteUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUserBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.Location = new System.Drawing.Point(692, 633);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(109, 32);
            this.deleteUserBtn.TabIndex = 10;
            this.deleteUserBtn.Text = "Delete User";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.refreshBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(25, 633);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(109, 32);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addUser1
            // 
            this.addUser1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.addUser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addUser1.Location = new System.Drawing.Point(452, 178);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(280, 364);
            this.addUser1.TabIndex = 9;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteUserBtn);
            this.Controls.Add(this.addUser1);
            this.Controls.Add(this.panelUpdateUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewNames);
            this.Controls.Add(this.label2);
            this.Name = "ManageUsers";
            this.Size = new System.Drawing.Size(1124, 701);
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNames)).EndInit();
            this.panelUpdateUser.ResumeLayout(false);
            this.panelUpdateUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewNames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.Panel panelUpdateUser;
        private System.Windows.Forms.Button updateUserbtn;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private AddUser addUser1;
        private System.Windows.Forms.Button closeUpdateBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}
