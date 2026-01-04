using ObserverPattern02.Domain;
using ObserverPattern02.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern02.Application
{
    internal class OrderSubjectService : IOrderSubject
    {
        List<IOrderObserver> _observers = new List<IOrderObserver>();
        public void CreateOrder(Order order)
        {
            // Business Logic
            Notify(order);
        }

        public void Subscribe(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify(Order order)
        {
            foreach (var item in _observers)
            {
                item.Update(order);
            }
        }
    }
}
