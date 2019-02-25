using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class FindDigits
    {
        static int findDigits(int n)
        {
            int originalNumber = n, count = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                if (remainder > 0 && originalNumber % remainder == 0)
                {
                    count++;
                }
                n = n / 10;
            }
            return count;
        }

        public static void GetDigitsCount()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = findDigits(n);
                Console.WriteLine(result);
            }
        }
    }
}
