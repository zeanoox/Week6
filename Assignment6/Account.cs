
namespace Assignment6
{
    internal class Account
    {
        private string AccountHolder;
        private double Amount;

        public Account(string accountHolder)
        {
            AccountHolder = accountHolder;
            Amount = 0;
        }

        public void Deposit(double amount)
        {
            Amount = amount;
            LogTransaction($"Amount {amount} deposit successful");
        }
        private void LogTransaction(string message)
        {
            Console.WriteLine($"[Log] : {message}");
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Name : {AccountHolder}");
            Console.WriteLine($"Amount : {Amount}");
        }
    }
}
