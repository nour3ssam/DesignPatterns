using FactoryMethodPattern.Methods.MethodsFactory;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var INotify = new PushNotificationCreator().CreateNotification();
            INotify.Send("I am Nour");

            INotify = new SMSNotificationCreator().CreateNotification();
            INotify.Send("I am Nour");

            INotify = new EmailNotificationCreator().CreateNotification();
            INotify.Send("I am Nour");



        }
    }
}
