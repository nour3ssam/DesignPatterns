using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub.Subscribers
{
    internal class Display
    {
        public Display(Broker broker)
        {
            broker.Subscribe("Temperature", EventDisplay);
        }
        public void EventDisplay(Eventargs temp)
        {
            Console.WriteLine($" In Display the temperature is changed by {temp.Temperature}");
        }
    }
}
