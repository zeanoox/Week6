namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program progarm = new Program();
            progarm.Start();
        }
        void Start()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            Account account = new Account(name);
            account.Deposit(amount);
            account.DisplayAccountInfo();
            
        }
    }
}
