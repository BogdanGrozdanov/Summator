using System;

namespace Summator
{
    public class Summator
    {
        static void Main(string[] args)
        {
            var arr = new long[] { 1,1};
            Console.WriteLine(Sum(arr));
        }
        public static long Sum(long[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }

        public static double Average(double[] arr)
        {
            double sum = 0;
            for (int i = 1; i < arr
              .Length; i++)
                sum += arr[i];
            return sum / arr.Length;
        }

    }
}
