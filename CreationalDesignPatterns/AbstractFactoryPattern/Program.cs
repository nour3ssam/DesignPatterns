using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankFactory bankFactory = new BankFactory();

            IBank bank = bankFactory.GetBank("123");   
            IPaymentCard paymentCard = bankFactory.GetPaymentCard("1233");
            Console.WriteLine(bank.Withdraw());
            Console.WriteLine(paymentCard.GetProvider());

            Console.ReadLine();
        }
    }
}
