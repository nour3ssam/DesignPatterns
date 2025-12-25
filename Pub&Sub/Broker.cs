using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub
{
    internal class Broker
    {
        Dictionary<string, List<Action<Eventargs>>> PubSub = new Dictionary<string, List<Action<Eventargs>>>();
        public void Subscribe(string key, Action<Eventargs> test)
        {
            if (!PubSub.ContainsKey(key))
                PubSub.Add(key, new List<Action<Eventargs>>());

            PubSub[key].Add(test);

        }
        public void Publish(string subject, Eventargs eventargs)
        {
            var subscribers = PubSub[subject];
            foreach (var item in subscribers)
            {
                item.Invoke(eventargs);
            }
        }
    }
}
