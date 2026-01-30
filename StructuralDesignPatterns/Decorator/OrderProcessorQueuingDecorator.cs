using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OrderProcessorQueuingDecorator : IOrderProcess
    {
        private readonly IOrderProcess orderProcess;
        public Queue<Order>queue = new Queue<Order>();


        public OrderProcessorQueuingDecorator(IOrderProcess orderProcess)
        {
            this.orderProcess = orderProcess;
        }
        public void process(Order order)
        {
            queue.Enqueue(order);
            orderProcess.process(order);
            Console.WriteLine("Order has been queued");


        }
    }
}
