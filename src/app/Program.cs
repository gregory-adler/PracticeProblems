using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Server testServer = new Server("john", 5);
            Table testTable = new Table(1, 4);
            Party testParty = new Party(4, false);
            testParty.Print();
            testServer.assignTable(testTable);
            testServer.getTable().Print();
        }
    }
}
