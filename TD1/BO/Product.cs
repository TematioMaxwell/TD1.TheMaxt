using MaLibrairie.MC1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.BO
{
    [Serializable]
    public class Product : BaseModel
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product()
        {

        }
        public Product(string reference, string name, double price, int quantity) :base(reference, name)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
