using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConstructRectangle test = new ConstructRectangle();
            int[] answer = new int [2];
            answer = test.constructRectangle(4);
            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
        }
    }
}
