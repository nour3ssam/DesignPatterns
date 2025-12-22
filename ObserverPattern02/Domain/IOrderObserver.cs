using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern02.Domain
{
    internal interface IOrderObserver
    {
        void Update(Order order);
    }
}
