
namespace Assignment3
{
    internal class Car
    {
        private string Make;
        private string Model;
        private int Year;
        public Car(string make , string model, int year)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public void Display()
        {
            Console.WriteLine("Car deails :");
            Console.WriteLine($"Make : {Make}");
            Console.WriteLine($"Moedl : {Model}");
            Console.WriteLine($"Year : {Year}");
        }
    }
}
