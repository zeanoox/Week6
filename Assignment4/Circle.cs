
namespace Assignment4
{
    internal class Circle
    {
        private double Radius;
        private double area;

        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
        public void Dispaly()
        {
            Console.WriteLine($"Area : {Area:0.00}");
        } 
    }
}
