using Model;

namespace View
{
    public class ProductView
    {
        public void ShowMenu()
        {
            Console.WriteLine("Enter number for option");
            Console.WriteLine("1: Show products");
            Console.WriteLine("2: Enter details for new product");
            Console.WriteLine("3: Enter ID of product to be removed");


        }

        public void ShowProducts(List<Product> products)
        {
            foreach (var product in products) 
                Console.WriteLine($"ID: {product.Id}; Name: {product.Name}; Price: {product.Price}");
        }

        public Product GetProductDetails()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price");
            decimal price = decimal.Parse(Console.ReadLine() ?? throw new Exception("Null value"));

            return new Product(name, price);
        }

        public Guid GetProductIDForRemoval()
        {
            Console.WriteLine("Product ID:");
            return Guid.Parse(Console.ReadLine() ?? throw new Exception("Null value"));
        }
    }
}
