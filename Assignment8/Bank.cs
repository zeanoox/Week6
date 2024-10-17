
namespace Assignment8
{
    internal class Bank
    {
        private string AccointNumber;
        private double Balance;
        public Bank()
        {
            AccointNumber = "123456";
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit successful.");
        }
        public void Withdraw(double amount)
        {
            
            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
            
            
        }
        public void Display()
        {

            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {AccointNumber}");
            Console.WriteLine($"Balance: {Balance:0.00}");
        }
    }
}
