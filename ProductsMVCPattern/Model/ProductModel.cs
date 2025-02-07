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

        public void RemoveProduct(int id)
        {
            foreach (Product product in products)
                if (product.Id == id)
                    products.Remove(product);
        }

        public static void DisplayProduct(Product product)
        {
            Console.WriteLine($"Name: {product.Name}; Price: {product.Price}");
        }
    }
}