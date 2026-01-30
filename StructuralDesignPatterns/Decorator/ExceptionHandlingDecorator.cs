using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ExceptionHandlingDecorator : IOrderProcess
    {
        private readonly IOrderProcess orderProcess;

        public ExceptionHandlingDecorator(IOrderProcess orderProcess)
        {
            this.orderProcess = orderProcess;
        }
        public void process(Order order)
        {
            try
            {
                orderProcess.process(order);
            }
            catch (Exception ex) {
                Console.WriteLine($"Process is Empty{ex.Message}");
            }
        }
    }
}
