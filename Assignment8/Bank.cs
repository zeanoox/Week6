
namespace Assignment8
{
    internal class Bank
    {
        private string accointNumber;
        private double balance;
        public Bank()
        {
            AccointNumber = "123456";
            Balance = 0;
        }
        public string AccointNumber
        {
            get { return accointNumber; }
            set { accointNumber = value; }
            
        }

        public double Balance
        {
            get { return balance; }
            set {  balance = value; }
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
