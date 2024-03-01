using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class StockClass
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }  
        public DateTime Addition_Date { get; set; }
        public string Worker_Name { get; set; }
        public string Worker_LastName { get; set; }

        public StockClass(int id, string Name, int Quantity, double Price, DateTime addition, string worker_name, string worker_lastname) 
        {
            this.id = id;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
            Addition_Date = addition;
            Worker_Name = worker_name;
            Worker_LastName = worker_lastname;
        }


    }
}
