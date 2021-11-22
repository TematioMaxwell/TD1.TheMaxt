using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    public class RptUserList
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public RptUserList(string reference, string name, double price, double quantity)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
