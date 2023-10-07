using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCondoleApp
{
    public interface IStore
    {
        List<Product> Products { get; }
        int ProductLimit { get; set; }
        decimal TotalIncome { get; }

        void AddProduct(Product product);
        void SellProduct(string number);
    }

}
