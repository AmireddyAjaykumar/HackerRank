using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class StrangeCounter
    {
        static long strangeCounter(long t)
        {
            long rem = 3;
            while (t > rem)
            {
                t = t - rem;
                rem *= 2;
            }
            return (rem - t + 1);
        }

        public static void Execute()
        {
            long t = Convert.ToInt64(Console.ReadLine());
            long result = strangeCounter(t);
            Console.WriteLine(result);
        }
    }
}
