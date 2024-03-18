namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            double depositAmmount = double.Parse(Console.ReadLine());
            account.Deposit (depositAmmount);
            var newBalance = account.GetBalance();
            Console.WriteLine($"your current balance is ${newBalance}.");
        }
    }
}
