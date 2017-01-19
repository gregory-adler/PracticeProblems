using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RomanNumerals test = new RomanNumerals();
            Console.WriteLine(test.IntToRoman(99));
            // NumberPalidrome test = new NumberPalidrome();
            // Console.WriteLine(test.isPalidrome(-2147483648));
        }
    }
}
