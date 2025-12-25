using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub.Publishers
{
    internal class Sensor
    {
        private readonly Broker broker;
        private int CurrentTemperature { get; set; }

        public Sensor(Broker broker)
        {
            this.broker = broker;
        }
        public void ChangeTemperature(int NewTemperature)
        {
            CurrentTemperature = NewTemperature;
            broker.Publish("Temperature", new Eventargs(CurrentTemperature));
        }

    }
}
