using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teemo test = new Teemo();
            int[] parameter = new int[] { 1, 2 };
            int answer;
            answer = test.FindPoisonedDuration(parameter, 2);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
