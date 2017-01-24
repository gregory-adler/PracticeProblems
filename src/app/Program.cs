using System;
using Library; 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[]{3,3,5,0,0,3,1,4};
            Console.WriteLine("Hello World!");
            StockMarketTiming test = new StockMarketTiming();
            Console.WriteLine(test.maxProfit(nums));
        }
    }
}
