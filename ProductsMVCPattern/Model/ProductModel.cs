using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductModel
    {
        List<Product> products = [];

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void RemoveProduct(Guid id)
        {
            products.RemoveAll(p => p.Id.Equals(id));
        }
    }
}