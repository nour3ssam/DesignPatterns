using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Methods
{
    internal class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"{message} = >>>>>>>push message");
        }
    }
}
