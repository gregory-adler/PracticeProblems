using System;
using Library;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String s = "1 ";
            stringReverse test = new stringReverse();
            Console.WriteLine(test.reverseWords(s));

        }

        public static void testRestaurant() { 
            Console.WriteLine("Hello World!");
            List<Employee> _Employees = new List<Employee>();
            List<Table> _Tables  = new List<Table>();
            List<Party> _Parties = new List<Party>();

            Server testServer = new Server("john", 5);
            Host testHost = new Host("Cool", 7);
            _Employees.Add(testServer);
            _Employees.Add(testHost);

            Table testTable = new Table(1, 4);
            Table testTable2 = new Table(2, 5);
            _Tables.Add(testTable);
            _Tables.Add(testTable2);

            Party testParty = new Party(4, true);
            Party testParty2 = new Party(5, true);
            _Parties.Add(testParty);
            _Parties.Add(testParty2);

            Restaurant testRestaurant = new Restaurant("string", _Employees, _Parties, _Tables);
            testRestaurant.Print();
        }
    }
}
