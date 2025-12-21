using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observers;
namespace ObserverPattern.Subjects
{
    internal class YoutubeChannel : ISubject
    {
        public List<IObserver> Subscribers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Subscribers.Add(observer);
        }

        public void Detch(IObserver observer)
        {
            Subscribers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(message);
            }

        }
    }
}
