using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OrderProcesserProfileDecorator : IOrderProcess
    {
        private readonly IOrderProcess orderProcess;

        public OrderProcesserProfileDecorator(IOrderProcess orderProcess)
        {
            this.orderProcess = orderProcess;
        }
        public void process(Order order)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            orderProcess.process(order);
            stopwatch.Stop();
            Console.WriteLine($"calculate time =  {stopwatch.Elapsed.TotalSeconds}");
        }
    }
}
