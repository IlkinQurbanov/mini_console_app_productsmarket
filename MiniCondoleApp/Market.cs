using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCondoleApp
{
    public class Market : IStore
    {
        private List<Product> _products = new List<Product>();
        private int _productLimit = 10;
        private decimal _totalIncome = 0;

        public List<Product> Products
        {
            get { return _products; }
        }

        public int ProductLimit
        {
            get { return _productLimit; }
            set { _productLimit = value; }
        }

        public decimal TotalIncome
        {
            get { return _totalIncome; }
        }

        public void AddProduct(Product product)
        {
            if (_products.Count < _productLimit && !_products.Any(p => p.Number == product.Number))
            {
                _products.Add(product);
                _totalIncome += product.Price;
            }
        }

        public void SellProduct(string number)
        {
            Product product = _products.FirstOrDefault(p => p.Number == number);
            if (product != null && product.Quantity > 0)
            {
                product.Quantity--;
                _totalIncome += product.Price;
            }
        }
    }

}
