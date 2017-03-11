using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Server test = new Server("john", 5);
            Console.WriteLine(test.getAge());
        }
    }
}
