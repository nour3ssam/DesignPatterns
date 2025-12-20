using Strategy.Customers;
using Strategy.DiscountStrategy;
using Strategy.Invoices;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ReadCustomers = new ReadCustomers();
            var customers = ReadCustomers.customers;
            Console.WriteLine("List of Customers");
            foreach (var custom in customers)
            {
                Console.WriteLine($"{custom.Id} - {custom.Name} ");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            while (true)
            {
                Console.WriteLine("Enter Customer ID");
                int CustomerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Quantity");
                int Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price");
                double Price = double.Parse(Console.ReadLine());

                var customer = customers.FirstOrDefault(x => x.Id == CustomerId);
                IDiscountStrategy DiscountStrategy = null;
                if (customer.CustomCatogery == Category.gold)
                {
                    DiscountStrategy = new GoldDiscountStrategy();
                }
                else if (customer.CustomCatogery == Category.silver)
                {
                    DiscountStrategy = new SilverDiscountStrategy();
                }
                var InvoiceManger = new InvoiceManger(DiscountStrategy);
                // this is strategy pattern 
                var Invoice = InvoiceManger.CreateInvoice(customer, Price, Quantity);



                Console.WriteLine($"Invoice to Customer {customer.Name} and Total Price is {Invoice.NetPrice}");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine("Enter Anything To Continue ");
                Console.ReadKey();
            }

        }
    }
}

