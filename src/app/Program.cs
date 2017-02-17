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
            restaurant.Host = new Host ("HostName", 4);
            Console.WriteLine(restaurant.Host.Name);
        }
    }
}
