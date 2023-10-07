using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCondoleApp
{
    public class Product
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string number, string name, decimal price, int quantity)
        {
            this.Number = number;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }

}
