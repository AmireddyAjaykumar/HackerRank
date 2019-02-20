using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class FlippingBits
    {
        static long flippingBits(long n)
        {
            return (long)Math.Pow(2, 32) - 1 - n;
        }

        public static void FlipBits()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                long result = flippingBits(n);
                Console.WriteLine(result);
            }
        }
    }
}
