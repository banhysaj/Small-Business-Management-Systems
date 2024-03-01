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
    public partial class Stock : UserControl
    {
        SQLoperations SQLoperations = new SQLoperations();
        public int id;
        public Stock()
        {
            InitializeComponent();
            populateStockTable();
            RemoveStockPanel.Visible = false;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            
        }
  
        public void populateStockTable()
        {

            dataGridViewStock.AutoGenerateColumns = false;
            BindingList<StockClass> data = SQLoperations.getStock();
            BindingSource bindingsource = new BindingSource();
            bindingsource.DataSource = data;
            dataGridViewStock.AutoGenerateColumns = true;
            dataGridViewStock.DataSource = bindingsource;
            dataGridViewStock.Columns["id"].Visible = false;
        }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void addStockbtn_Click(object sender, EventArgs e)
        {
            panelAddStock.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void updateUserbtn_Click(object sender, EventArgs e)
        {
            string name = stockTextBox.Text;
            int quantity = (int)numericQuanitity.Value;
            double price = (double)numericPrice.Value;
            int passedID = (int)passID.Value;
            SQLoperations.addStock(name, quantity, price, passedID);
            populateStockTable();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            populateStockTable();
        }

        private void closeUpdateBtn_Click(object sender, EventArgs e)
        {
            panelAddStock.Visible = false;
        }

        private void dataGridViewStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dataGridViewStock.SelectedRows.Count > 0)
            {
                id = (int)dataGridViewStock.SelectedRows[0].Cells[0].Value;
            }
        }

        private void removeStockBtn_Click(object sender, EventArgs e)
        {
            RemoveStockPanel.Visible = true;
            
            
        }

        private void CloseStockRemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveStockPanel.Visible = false;
        }

        private void ConfirmRemoveBtn_Click(object sender, EventArgs e)
        {
            int quantityToRemove = (int)RemoveStockBtnNumeric.Value;
            Console.WriteLine("Quantity: " + quantityToRemove);
            if (id > 0 && quantityToRemove > 0)
            {
                if(SQLoperations.removeStock(id, quantityToRemove))
                {
                    MessageBox.Show("Removed successfully");
                    populateStockTable();
                }
                else
                {
                    MessageBox.Show("Not enough quantity to remove");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity or select a product");
            }
        }

        private void AddStockConfirmBtn_Click(object sender, EventArgs e)
        {
            int quantityToAdd = (int)RemoveStockBtnNumeric.Value;

            if(id > 0)
            {
                SQLoperations.addExistingStock(id, quantityToAdd);
                MessageBox.Show("Added successfully");
                populateStockTable();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity or select a product");
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SQLoperations.deleteProduct(id);
                MessageBox.Show("Product deleted successfully");
                populateStockTable();
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }
    }
}
