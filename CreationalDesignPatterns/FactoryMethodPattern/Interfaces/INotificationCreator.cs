using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Interfaces
{
    internal abstract class NotificationCreator // must abstract class not interface
    {
        public abstract INotification CreateNotification();
    }
}
