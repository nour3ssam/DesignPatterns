using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub.Subscribers
{
    internal class Alarm
    {
        private int CurrentAlarm;
        public Alarm(int newalarm, Broker broker)
        {
            CurrentAlarm = newalarm;
            broker.Subscribe("Temperature", EventAlarm);
        }
        public Alarm(int newalarm)
        {
            CurrentAlarm = newalarm;
        }
        public void SetAlarm(int newalarm)
        {
            CurrentAlarm = newalarm;
        }
        public void EventAlarm(Eventargs temp)
        {
            if (temp.Temperature > CurrentAlarm)
            {
                Console.WriteLine($"this is dangerous your temperature is bigger than CurrentAlarm => {CurrentAlarm}");
            }
        }



    }
}
