using TemplateMethod.Customers;
using TemplateMethod.Items;
using TemplateMethod.ShoppingCarts;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var readCustomers = new ReadCustomers();
            var customers = readCustomers.Customers; 
            Console.WriteLine("List of Customers");
            foreach (var custom in customers)
            {
                Console.WriteLine($"{custom.Id} - {custom.Name} ");
            }
            Console.WriteLine("-------------------------------");
            var items = new ItemDataLeader().GetItems();
            Console.WriteLine("List of Items");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.UnitPrice}");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");


            Customer? customer = null;
            while (customer == null)
            {
                Console.Write("Enter Customer ID: ");
                if (!int.TryParse(Console.ReadLine(), out int customerId))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }
                customer = customers.FirstOrDefault(c => c.Id == customerId);
                if (customer == null)
                {
                    Console.WriteLine("Customer not found - try again ");
                }
            }


 
            ShoppingCart? shoppingCart = null;
            while (shoppingCart == null)
            {
                Console.Write("Select Shopping Cart type (InStore | Online): ");
                var type = Console.ReadLine();

                if (string.Equals(type, "InStore", StringComparison.OrdinalIgnoreCase))
                    shoppingCart = new InStoreShoppingCart();
                else if (string.Equals(type, "Online", StringComparison.OrdinalIgnoreCase))
                    shoppingCart = new OnlineShoppingCart();
                else
                    Console.WriteLine("Invalid input. Try again.");
            }



            while (true) {
                Console.WriteLine("Enter ItemID to add in cart " +
                    "OR[0 to complete this Order]");
                if (!int.TryParse(Console.ReadLine(), out int itemId))
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }
                if (itemId == 0)
                {
                    break;
                }
                else
                {
                    var item = items.FirstOrDefault(i=> i.Id == itemId);
                    if (item == null)
                    {
                        Console.WriteLine("Item not found ");
                        continue;
                    }

                    Console.Write("Enter Item Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
                    {
                        Console.WriteLine("Invalid quantity.");
                        continue;
                    }
                    shoppingCart.AddItem(itemId, quantity, item.UnitPrice);
                }  
            }
            shoppingCart.Checkout(customer);


        }
    }
}
