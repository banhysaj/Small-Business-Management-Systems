namespace Project
{
    partial class Stock
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
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.addStockbtn = new System.Windows.Forms.Button();
            this.panelAddStock = new System.Windows.Forms.Panel();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericQuanitity = new System.Windows.Forms.NumericUpDown();
            this.closeUpdateBtn = new System.Windows.Forms.Button();
            this.updateUserbtn = new System.Windows.Forms.Button();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passID = new System.Windows.Forms.NumericUpDown();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.removeStockBtn = new System.Windows.Forms.Button();
            this.RemoveStockPanel = new System.Windows.Forms.Panel();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.AddStockConfirmBtn = new System.Windows.Forms.Button();
            this.RemoveStockBtnNumeric = new System.Windows.Forms.NumericUpDown();
            this.CloseStockRemoveBtn = new System.Windows.Forms.Button();
            this.ConfirmRemoveBtn = new System.Windows.Forms.Button();
            this.RemoveQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.panelAddStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuanitity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passID)).BeginInit();
            this.RemoveStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveStockBtnNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(92, 184);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(650, 276);
            this.dataGridViewStock.TabIndex = 0;
            this.dataGridViewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewStock.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewStock_MouseDoubleClick);
            // 
            // addStockbtn
            // 
            this.addStockbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(176)))));
            this.addStockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStockbtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockbtn.Location = new System.Drawing.Point(477, 484);
            this.addStockbtn.Name = "addStockbtn";
            this.addStockbtn.Size = new System.Drawing.Size(109, 32);
            this.addStockbtn.TabIndex = 1;
            this.addStockbtn.Text = "Add Product";
            this.addStockbtn.UseVisualStyleBackColor = false;
            this.addStockbtn.Click += new System.EventHandler(this.addStockbtn_Click);
            // 
            // panelAddStock
            // 
            this.panelAddStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddStock.Controls.Add(this.numericPrice);
            this.panelAddStock.Controls.Add(this.numericQuanitity);
            this.panelAddStock.Controls.Add(this.closeUpdateBtn);
            this.panelAddStock.Controls.Add(this.updateUserbtn);
            this.panelAddStock.Controls.Add(this.stockTextBox);
            this.panelAddStock.Controls.Add(this.label3);
            this.panelAddStock.Controls.Add(this.label1);
            this.panelAddStock.Controls.Add(this.label5);
            this.panelAddStock.Location = new System.Drawing.Point(796, 184);
            this.panelAddStock.Name = "panelAddStock";
            this.panelAddStock.Size = new System.Drawing.Size(259, 276);
            this.panelAddStock.TabIndex = 9;
            this.panelAddStock.Visible = false;
            // 
            // numericPrice
            // 
            this.numericPrice.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrice.Location = new System.Drawing.Point(46, 177);
            this.numericPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(162, 24);
            this.numericPrice.TabIndex = 35;
            // 
            // numericQuanitity
            // 
            this.numericQuanitity.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuanitity.Location = new System.Drawing.Point(46, 119);
            this.numericQuanitity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericQuanitity.Name = "numericQuanitity";
            this.numericQuanitity.Size = new System.Drawing.Size(162, 24);
            this.numericQuanitity.TabIndex = 34;
            // 
            // closeUpdateBtn
            // 
            this.closeUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.closeUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeUpdateBtn.Font = new System.Drawing.Font("Helvetica CondensedBlack", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeUpdateBtn.Location = new System.Drawing.Point(214, 13);
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
            this.updateUserbtn.Location = new System.Drawing.Point(87, 216);
            this.updateUserbtn.Name = "updateUserbtn";
            this.updateUserbtn.Size = new System.Drawing.Size(80, 27);
            this.updateUserbtn.TabIndex = 32;
            this.updateUserbtn.Text = "Add";
            this.updateUserbtn.UseVisualStyleBackColor = false;
            this.updateUserbtn.Click += new System.EventHandler(this.updateUserbtn_Click);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(46, 57);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(162, 24);
            this.stockTextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // passID
            // 
            this.passID.Location = new System.Drawing.Point(487, 78);
            this.passID.Name = "passID";
            this.passID.Size = new System.Drawing.Size(120, 20);
            this.passID.TabIndex = 10;
            this.passID.Visible = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(114, 484);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(109, 32);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh Table";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // removeStockBtn
            // 
            this.removeStockBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeStockBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeStockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeStockBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStockBtn.Location = new System.Drawing.Point(614, 484);
            this.removeStockBtn.Name = "removeStockBtn";
            this.removeStockBtn.Size = new System.Drawing.Size(109, 32);
            this.removeStockBtn.TabIndex = 12;
            this.removeStockBtn.Text = "Edit";
            this.removeStockBtn.UseVisualStyleBackColor = false;
            this.removeStockBtn.Click += new System.EventHandler(this.removeStockBtn_Click);
            // 
            // RemoveStockPanel
            // 
            this.RemoveStockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemoveStockPanel.Controls.Add(this.DeleteProductBtn);
            this.RemoveStockPanel.Controls.Add(this.AddStockConfirmBtn);
            this.RemoveStockPanel.Controls.Add(this.RemoveStockBtnNumeric);
            this.RemoveStockPanel.Controls.Add(this.CloseStockRemoveBtn);
            this.RemoveStockPanel.Controls.Add(this.ConfirmRemoveBtn);
            this.RemoveStockPanel.Controls.Add(this.RemoveQuantity);
            this.RemoveStockPanel.Location = new System.Drawing.Point(316, 214);
            this.RemoveStockPanel.Name = "RemoveStockPanel";
            this.RemoveStockPanel.Size = new System.Drawing.Size(359, 203);
            this.RemoveStockPanel.TabIndex = 13;
            this.RemoveStockPanel.Visible = false;
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.DeleteProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductBtn.Location = new System.Drawing.Point(240, 123);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(99, 27);
            this.DeleteProductBtn.TabIndex = 36;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // AddStockConfirmBtn
            // 
            this.AddStockConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(176)))));
            this.AddStockConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStockConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStockConfirmBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockConfirmBtn.Location = new System.Drawing.Point(127, 123);
            this.AddStockConfirmBtn.Name = "AddStockConfirmBtn";
            this.AddStockConfirmBtn.Size = new System.Drawing.Size(99, 27);
            this.AddStockConfirmBtn.TabIndex = 35;
            this.AddStockConfirmBtn.Text = "Add Stock";
            this.AddStockConfirmBtn.UseVisualStyleBackColor = false;
            this.AddStockConfirmBtn.Click += new System.EventHandler(this.AddStockConfirmBtn_Click);
            // 
            // RemoveStockBtnNumeric
            // 
            this.RemoveStockBtnNumeric.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStockBtnNumeric.Location = new System.Drawing.Point(106, 70);
            this.RemoveStockBtnNumeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.RemoveStockBtnNumeric.Name = "RemoveStockBtnNumeric";
            this.RemoveStockBtnNumeric.Size = new System.Drawing.Size(162, 24);
            this.RemoveStockBtnNumeric.TabIndex = 34;
            // 
            // CloseStockRemoveBtn
            // 
            this.CloseStockRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.CloseStockRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseStockRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseStockRemoveBtn.Font = new System.Drawing.Font("Helvetica CondensedBlack", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseStockRemoveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseStockRemoveBtn.Location = new System.Drawing.Point(314, 10);
            this.CloseStockRemoveBtn.Name = "CloseStockRemoveBtn";
            this.CloseStockRemoveBtn.Size = new System.Drawing.Size(25, 26);
            this.CloseStockRemoveBtn.TabIndex = 33;
            this.CloseStockRemoveBtn.Text = "X";
            this.CloseStockRemoveBtn.UseVisualStyleBackColor = false;
            this.CloseStockRemoveBtn.Click += new System.EventHandler(this.CloseStockRemoveBtn_Click);
            // 
            // ConfirmRemoveBtn
            // 
            this.ConfirmRemoveBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmRemoveBtn.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmRemoveBtn.Location = new System.Drawing.Point(14, 123);
            this.ConfirmRemoveBtn.Name = "ConfirmRemoveBtn";
            this.ConfirmRemoveBtn.Size = new System.Drawing.Size(99, 27);
            this.ConfirmRemoveBtn.TabIndex = 32;
            this.ConfirmRemoveBtn.Text = "Remove Stock";
            this.ConfirmRemoveBtn.UseVisualStyleBackColor = false;
            this.ConfirmRemoveBtn.Click += new System.EventHandler(this.ConfirmRemoveBtn_Click);
            // 
            // RemoveQuantity
            // 
            this.RemoveQuantity.AutoSize = true;
            this.RemoveQuantity.Font = new System.Drawing.Font("Helvetica CondensedLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveQuantity.Location = new System.Drawing.Point(103, 48);
            this.RemoveQuantity.Name = "RemoveQuantity";
            this.RemoveQuantity.Size = new System.Drawing.Size(45, 16);
            this.RemoveQuantity.TabIndex = 23;
            this.RemoveQuantity.Text = "Quantity";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveStockPanel);
            this.Controls.Add(this.removeStockBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.passID);
            this.Controls.Add(this.panelAddStock);
            this.Controls.Add(this.addStockbtn);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(1124, 701);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.panelAddStock.ResumeLayout(false);
            this.panelAddStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuanitity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passID)).EndInit();
            this.RemoveStockPanel.ResumeLayout(false);
            this.RemoveStockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveStockBtnNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button addStockbtn;
        private System.Windows.Forms.Panel panelAddStock;
        private System.Windows.Forms.Button closeUpdateBtn;
        private System.Windows.Forms.Button updateUserbtn;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericQuanitity;
        public System.Windows.Forms.NumericUpDown passID;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button removeStockBtn;
        private System.Windows.Forms.Panel RemoveStockPanel;
        private System.Windows.Forms.NumericUpDown RemoveStockBtnNumeric;
        private System.Windows.Forms.Button CloseStockRemoveBtn;
        private System.Windows.Forms.Button ConfirmRemoveBtn;
        private System.Windows.Forms.Label RemoveQuantity;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button AddStockConfirmBtn;
    }
}
