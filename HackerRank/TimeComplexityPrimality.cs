using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class TimeComplexityPrimality
    {
        static string primality(int n)
        {
            if (n == 1)
            {
                return "Not prime";
            }
            if (n > 1 && n < 4)
            {
                return "Prime";
            }
            int l = (int)Math.Sqrt(n);
            for (int i = 2; i <= l; i++)
            {
                if (n % i == 0)
                {
                    return "Not prime";
                }
            }
            return "Prime";
        }

        public static void Primality()
        {
            int p = Convert.ToInt32(Console.ReadLine());
            for (int pItr = 0; pItr < p; pItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string result = primality(n);
                Console.WriteLine(result);
            }
        }
    }
}
