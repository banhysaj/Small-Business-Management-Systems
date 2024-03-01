using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System;

namespace Project
{
    internal class DBConnect
    {
        
        private static string server = "localhost";
        private static string database = "csdatabase";
        private static string uid = "root";
        private static string password = "";
        public static string connectionString = $"Server={server};Database={database};User ID={uid};Password={password};";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public DBConnect()
        {
        }

        public static void connectDB()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void closeConnection()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

