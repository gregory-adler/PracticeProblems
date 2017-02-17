using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Restaurant restaurant = new Restaurant();
            restaurant.Host = new Host ("CoolGuyHost", 4, "host");
            restaurant.Host.EmployeeProperties();
            Server zo = new Server("Zo", 5, "server");
            Server tim = new Server("Tim", 7, "server");
            restaurant.Servers.Add(zo);
            restaurant.Servers.Add(tim);
            restaurant.printServers();
        }
    }
}
