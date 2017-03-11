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
            Table testTable = new Table(4);
            Party testParty = new Party(4);
            test.Print();
        }
    }
}
