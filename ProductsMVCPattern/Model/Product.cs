namespace Model
{
    public class Product
    {

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
