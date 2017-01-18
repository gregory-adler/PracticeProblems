using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NumberPalidrome test = new NumberPalidrome();
            Console.WriteLine(test.isPalidrome(-2147483648));
        }
    }
}
