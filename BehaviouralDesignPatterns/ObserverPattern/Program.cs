using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = new YoutubeChannel();
            var user01 = new User("Nour");
            var user02 = new User("Malek");

            channel.Attach(user01);
            channel.Attach(user02);

            channel.Notify("(Be consistent)");

            channel.Detch(user01);
            channel.Notify("Be alone");
        }
    }
}
