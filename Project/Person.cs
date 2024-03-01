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


namespace Project
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; } 
        public string Type { get; set; }

        public Person(int id, string name, string lastname, string email, string password, string type)
        {
            ID = id;
            Name = name;
            Surname = lastname;
            Email = email; 
            Password = password;
            Type = type;
        }
    }
}
