﻿using System.ComponentModel.DataAnnotations;

namespace Assignment7
{
    internal class Product
    {
        private string name;
        private double price;
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public string Name
        {
            get {  return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set {  price = value; }
        }

        public void Display()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
