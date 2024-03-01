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
using System.Xml.Linq;
using System.Runtime.InteropServices;


namespace Project
{
    internal class SQLoperations
    {
        string query;
        public List<String> names;

        public SQLoperations()
        {
            names = new List<String>();
        }

        public List<String> totalUsers()
        {
            DBConnect.connectDB();
            query = "SELECT name FROM user";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                names.Add(reader["name"].ToString());
            }
            reader.Close();
            DBConnect.connection.Close();
            return names;
        }
        public BindingList<Person> getPerson()
        {
            DBConnect.connectDB();
            BindingList<Person> users = new BindingList<Person>();
            string query = "SELECT User.id, User.name, User.last_name, User.email, User.password, UserLevel.u_type FROM User INNER JOIN UserLevel ON User.id_type = UserLevel.id";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                Person p1 = new Person(reader.GetInt32("id") ,reader["name"].ToString(),reader["last_name"].ToString(), reader["email"].ToString(), reader["password"].ToString(), reader["u_type"].ToString());
                users.Add(p1);
            }
            reader.Close();
            DBConnect.closeConnection();
            return users;
        }

        public void AddNewUser(string name, string lastname, string email, string password, int id_type)
        {
            query = "INSERT INTO `user` (`name`, `last_name`, `email`, `password`, `id_type`) VALUES (@name, @lastname, @email, @password, @id_type)"; 
            DBConnect.connectDB();
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@id_type", id_type);
           
            int rowsAffected = cmd.ExecuteNonQuery();

            
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data inserted successfully!");
            }
            else
            {
                MessageBox.Show("Insert failed!");
                
            }
            DBConnect.closeConnection();
        }

        public void addStock(string product, int quantity, double price, int workerid)
        {
            DBConnect.connectDB();
            DateTime additionDate = DateTime.Now;
            query = "INSERT INTO `stock` (`product`, `quantity`, `price`, `additionDate`, `workerid`) VALUES (@product, @quantity, @price, @additionDate, @workerid)";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            cmd.Parameters.AddWithValue("@product", product);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@additionDate", additionDate);
            cmd.Parameters.AddWithValue("@workerid", workerid);
            cmd.ExecuteNonQuery();

            DBConnect.closeConnection();
        }

        public bool removeStock(int id, int quantityToRemove)
        {
            DBConnect.connectDB();
            int currentQuantity = 0;
            query = "SELECT quantity FROM stock WHERE id = @id";
            MySqlCommand checkCmd = new MySqlCommand(query, DBConnect.connection);
            checkCmd.Parameters.AddWithValue("@id", id);
            currentQuantity = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (currentQuantity < quantityToRemove)
            {
                DBConnect.closeConnection();
                return false;
            }
            else
            {
                query = "UPDATE stock SET quantity = quantity - @quantityToRemove WHERE id = @id";
                MySqlCommand removeCmd = new MySqlCommand(query, DBConnect.connection);
                removeCmd.Parameters.AddWithValue("@quantityToRemove", quantityToRemove);
                removeCmd.Parameters.AddWithValue("@id", id);
                removeCmd.ExecuteNonQuery();
                DBConnect.closeConnection();
                return true;
            }
        }

        public void addExistingStock(int id, int quantitytoAdd)
        {
            DBConnect.connectDB();
            query = "UPDATE stock SET quantity = quantity + @quantitytoAdd WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            cmd.Parameters.AddWithValue("@quantitytoAdd", quantitytoAdd);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            DBConnect.closeConnection();
        }

        public void deleteProduct(int id)
        {
            DBConnect.connectDB();
            query = "DELETE FROM stock WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            DBConnect.closeConnection();

        }

        public int ConvertUserType( string type)
        {
            query = "SELECT id FROM `userlevel` WHERE u_type = @type";
            DBConnect.connectDB();
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);

            cmd.Parameters.AddWithValue("@type", type);

            
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                DBConnect.closeConnection();
                return Convert.ToInt32(result);
            }
            else
            {
                DBConnect.closeConnection();
                return -1;
            }
        }

        public void UpdateSelectedUser(int id, string name, string lastname, string email, string password)
        {
            
            bool isEmailChanged = IsEmailChanged(id, email);

            if (isEmailChanged)
            {
                query = "UPDATE `user` SET `name` = @name, `last_name` = @lastname, `email` = @email, `password` = @password WHERE `id` = @id";
            }
            else
            {
                query = "UPDATE `user` SET `name` = @name, `last_name` = @lastname, `password` = @password WHERE `id` = @id";
            }

            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);

            if (isEmailChanged)
            {
                cmd.Parameters.AddWithValue("@email", email);
            }

            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@id", id);

            DBConnect.connectDB();

            int rowsAffected = cmd.ExecuteNonQuery();


            if (rowsAffected > 0)
            {
                MessageBox.Show("Data inserted successfully!");
            }
            else
            {
                MessageBox.Show("Insert failed!");
            }
            DBConnect.closeConnection();
        }

        private bool IsEmailChanged(int id, string newEmail)
        {
            DBConnect.connectDB();
            query = "SELECT email FROM `user` WHERE `id` = @id";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            cmd.Parameters.AddWithValue("@id", id);

            string result = cmd.ExecuteScalar().ToString();

            if(result == newEmail)
            {
                DBConnect.closeConnection();
                return false;
            }
            else 
            {
                DBConnect.closeConnection();
                return true;
            }

        }

        public void deleteUser(int id)
        {
            DBConnect.connectDB();

            query = "DELETE FROM `user` WHERE `id` = @id";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            DBConnect.closeConnection();
        }

        public BindingList<StockClass> getStock()
        {
            DBConnect.connectDB();
            BindingList<StockClass> results = new BindingList<StockClass>();
            string query = "SELECT Stock.id, Stock.product, Stock.quantity, Stock.price, Stock.additionDate, User.name, User.last_name FROM Stock INNER JOIN User ON Stock.workerid = User.id";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StockClass stock = new StockClass(reader.GetInt32("id"), reader["product"].ToString(), reader.GetInt32("quantity"), reader.GetDouble("price"), reader.GetDateTime("additionDate"), reader["name"].ToString(), reader["last_name"].ToString());
                results.Add(stock);
            }
            reader.Close();
            DBConnect.closeConnection();
            return results;
        }

        public int totalProducts()
        {
            List<int> products = new List<int>();
            DBConnect.connectDB();
            query = "SELECT id FROM stock";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                names.Add(reader["id"].ToString());
            }
            reader.Close();
            int num = names.Count;
            DBConnect.connection.Close();
            return num;
        }
        public string getName(int id_user)
        {
            int id = id_user;
            DBConnect.connectDB();
            string query = "SELECT `name` FROM `user` WHERE `id` = @id";

            MySqlCommand cmd = new MySqlCommand(query, DBConnect.connection);
            
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                string name = reader["name"].ToString();
                DBConnect.closeConnection();
                return name;
            }
            else
            {
                DBConnect.closeConnection();
                return null; 
            }
            
            
        }

    }
}

