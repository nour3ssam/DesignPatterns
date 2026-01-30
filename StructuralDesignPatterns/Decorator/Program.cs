namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.Lines.Add(new OrderLine()
            {
                ItemId = 1,
                Quentity = 2,
                UnitPrice = 4000
            });
            order.Lines.Add(new OrderLine()
            {
                ItemId = 2,
                Quentity = 4,
                UnitPrice = 5000
            });
            order.Lines.Add(new OrderLine()
            {
                ItemId = 3,
                Quentity = 1,
                UnitPrice = 6000
            });
            IOrderProcess orderProcess = new OrderProcess();
            orderProcess = new ExceptionHandlingDecorator(orderProcess);
            orderProcess = new OrderProcesserProfileDecorator(orderProcess);
            orderProcess = new OrderProcessorQueuingDecorator(orderProcess);

            orderProcess.process(order);


        }
    }
}
