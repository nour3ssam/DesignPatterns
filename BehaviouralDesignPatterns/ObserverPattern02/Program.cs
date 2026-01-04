using ObserverPattern02.Application;
using ObserverPattern02.Domain;
using ObserverPattern02.Observers;

namespace ObserverPattern02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order01 = new Order()
            {
                Id = 1,
                ProductName = "potato"
            };
            Order order02 = new Order()
            {
                Id = 2,
                ProductName = "tomato"
            };
            IOrderSubject orderSubject = new OrderSubjectService();
            IOrderObserver orderObserver01 = new OrderObserver();
            IOrderObserver orderObserver02 = new OrderObserver();
            IOrderObserver orderObserver03 = new EmailObserver();
            IOrderObserver orderObserver04 = new LogObserver();
            orderSubject.Subscribe(orderObserver01);
            orderSubject.Subscribe(orderObserver02);
            orderSubject.Subscribe(orderObserver03);
            orderSubject.Subscribe(orderObserver04);
            orderSubject.CreateOrder(order01);
            orderSubject.CreateOrder(order02);


        }
    }
}
