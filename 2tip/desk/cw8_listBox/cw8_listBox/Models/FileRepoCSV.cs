using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8_listBox.Models
{
    public class FileRepoCSV :IRepository
    {
        public List<Product>? Products { get; set; }

        public FileRepoCSV(string filename="products.csv") {
            Products = FileFromFile(filename);
        }

        private List<Product>? FileFromFile(string filename) {
            //todo
            List<string> lines = new List<string>();
            if (File.Exists(filename)) {
                lines = File.ReadAllLines(filename).ToList();
            }
            return null;
        }

        public List<Product> GetProducts() {
            return Products?? new List<Product>();
        }
    }
}
