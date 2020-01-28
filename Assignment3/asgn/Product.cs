using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgn
{
    class Product
    {
        public Product(string name, double price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;

        }
        public string name;
        public double price;
        public int quantity;
        public string type;
    }
}
