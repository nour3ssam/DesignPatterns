using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OrderProcess : IOrderProcess
    {
        public void process(Order order)
        {
            if (order.Lines.Count()==0)
            {
                throw new ArgumentException("xxxxxxxxxxxxxxxxxxxxxxxx");

            }
            // Simulating
           Thread.Sleep(4000);
            Console.WriteLine("Order has been Created");

            
        }
    }
}
