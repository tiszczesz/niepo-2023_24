using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8_listBox.Models
{
    public interface IRepository {
        List<Product> GetProducts();
    }
}
