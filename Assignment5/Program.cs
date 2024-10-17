namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int number = 10;

            Console.WriteLine($"Original value: {number}");

            ModifyByValue(number);
            Console.WriteLine($"Value after ModifyByValue: {number}");

            ModifyByReference(ref number);
            Console.WriteLine($"Value after ModifyByReference: {number}");
        }
        void ModifyByValue(int value)
        {
            value = 20;
        }
        void ModifyByReference(ref int value)
        {
            value = 20;
        }
    }
}
