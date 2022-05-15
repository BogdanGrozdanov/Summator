using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public class SummatorCode
    {
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
            for (int i = 0; i < arr
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
