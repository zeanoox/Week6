namespace Assignment8
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
            Bank account = new Bank();

            Console.Write("Enter deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());
            account.Deposit(deposit);

            Console.WriteLine();

            Console.Write("Enter withdrawal amount: ");
            double withrael = double.Parse(Console.ReadLine());
            account.Withdraw(withrael);

            Console.WriteLine();

            account.Display();
        }
    }
}
