using ObserverPattern02.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern02.Observers
{
    internal class OrderObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"{order.Id} With Product {order.ProductName} Is Delivered");
        }
    }
}
