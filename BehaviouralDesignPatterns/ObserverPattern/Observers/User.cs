using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    internal class User : IObserver
    {
        private readonly string name;

        public User(string name)
        {
            this.name = name;
        }
        public void Update(string massage)
        {
            Console.WriteLine($" new video for you {name} is {massage} ");
        }
    }
}
