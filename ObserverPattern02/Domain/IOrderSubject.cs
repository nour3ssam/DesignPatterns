using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern02.Domain
{
    internal interface IOrderSubject
    {
        void Subscribe(IOrderObserver observer);
        void UnSubscribe(IOrderObserver observer);
        void CreateOrder(Order order);
    }
}
