using MaLibrairie.MC1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.BO
{
    [Serializable]
    public class User:BaseModel
    {
        public string Password { get; set; }
        public List<Product> Products;
        public User()
        {

        }
        public User(string email, string name, string password, List<Product> products) : base(email, name)
        {
            this.Products = new List<Product>();
            Password = password;
            Products = products;
        }
        public User(string email, string name) : base(email, name)
        {
            this.Products = new List<Product>();
        }
        public User(string email, string name, string password) : this(email, name)
        {
            Password = password;
        }
        public double GetTotal()
        {
            double sum = 0;
            foreach (var item in this.Products)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
