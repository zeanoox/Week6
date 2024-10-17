
namespace Assignment4
{
    internal class Circle
    {
        private double Radius;
        private double Area;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Calculate()
        {
            Area = Radius * Radius * Math.PI;
            return Area;
        }
        public void Dispaly()
        {
            Console.WriteLine($"Area : {Area:0.00}");
        } 
    }
}
