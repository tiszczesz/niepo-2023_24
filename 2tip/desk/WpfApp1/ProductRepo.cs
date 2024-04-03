using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ProductRepo
    {
        public static List<Product> GetProducts() {
            return new List<Product>() {
                new Product() { Id = 1, Name = "aaaa", Price = 23.89m, Description = "adas dasa" },
                new Product() { Id = 2, Name = "ggg", Price = 23.89m, Description = "adas dasa" },
                new Product() { Id = 3, Name = "fff", Price = 13.89m, Description = "adas dasa" },
                new Product() { Id = 4, Name = "fff", Price = 44.89m, Description = "adas dasa" },
            };
        }
    }
}
