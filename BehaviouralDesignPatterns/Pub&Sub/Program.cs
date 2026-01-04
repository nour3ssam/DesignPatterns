using Pub_Sub.Publishers;
using Pub_Sub.Subscribers;

namespace Pub_Sub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Broker broker = new Broker(); // Broker

            Sensor sensor = new Sensor(broker); // Publisher
            // Subscribers
            Alarm alarm = new Alarm(20, broker);
            Display display = new Display(broker);



            while (true)
            {
                Console.WriteLine("welcome to Temperature system Defualt Alarm is 20");
                Console.WriteLine("1 .Set a temperature ");
                Console.WriteLine("2 .Set the alarm value ");
                Console.WriteLine("3 .Exit");
                int result = int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        Console.WriteLine("pls Enter the temperature value in Degree ");
                        int temperature = int.Parse(Console.ReadLine());
                        sensor.ChangeTemperature(temperature);
                        break;
                    case 2:
                        Console.WriteLine("pls Enter the temperature value for the alarm ");
                        int valueAlarm = int.Parse(Console.ReadLine());
                        alarm.SetAlarm(valueAlarm);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Wrong input pls try again! ");
                        break;
                }
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------");

            }
        }
    }
}
