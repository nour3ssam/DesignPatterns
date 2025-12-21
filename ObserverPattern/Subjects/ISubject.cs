using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
    public interface ISubject
    {
        public void Attach(IObserver observer);
        public void Detch(IObserver observer);
        public void Notify(string message);


    }
}
