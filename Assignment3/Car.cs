
namespace Assignment3
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        public Car(string make , string model, int year)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set {  year = value; }       
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
