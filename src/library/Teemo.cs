using System;

namespace Library
{
    public class Teemo
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            if (duration <= 0)
            {
                return 0;
            }

            int answer = 0;
            int difference;

            Console.WriteLine("Array");
            for (int i =0; i < timeSeries.Length; i++)
            {
                Console.WriteLine(timeSeries[i]);
            }

            for (int i=0; i< timeSeries.Length; i++)
            {
                if (i+1 >= timeSeries.Length)
                {
                    answer = answer + duration;
                }
                else { 
                    difference = timeSeries[i+1] - timeSeries[i];
                    if (difference < duration)
                    {
                        answer += difference;
                    }
                    else
                    {
                        answer += duration;
                    }
                }
            }

            return answer;

        }
    }
}
