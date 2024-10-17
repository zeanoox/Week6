using System.ComponentModel.DataAnnotations;

namespace Assignment7
{
    internal class Product
    {
        private string Name;
        private double Price;
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
