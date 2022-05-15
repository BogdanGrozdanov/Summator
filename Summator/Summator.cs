using System;

namespace Summator
{
    public class Summator
    {
        static void Main(string[] args)
        {
            var arr = new long[] { 1, 1 };
            Console.WriteLine(Sum(arr));
        }
        public static long Sum(long[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }

        public static long Average(long[] arr)
        {
            long sum = 0;
            for (int i = 1; i < arr
              .Length; i++)
                sum += arr[i];
            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                return sum / arr.Length;
            }

            
            
            


        }

    }
}
