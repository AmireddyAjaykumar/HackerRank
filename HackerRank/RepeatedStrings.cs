using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class RepeatedStrings
    {
        static long repeatedString(string s, long n)
        {
            long strLength = s.Length;            
            if (strLength == 1 && s == "a")
            {
                return n;
            }
            long currentStringLength = s.ToCharArray().Count(x => x == 'a');
            long noOfTimestoRepeat = n / strLength;
            long remainder = n % strLength;
            long repeat = (currentStringLength * noOfTimestoRepeat) + s.Substring(0, Convert.ToInt32(remainder)).ToCharArray().Count(x => x == 'a');
            return repeat;
        }

        public static long GetInput()
        {
            string s = Console.ReadLine().Trim();
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            long result = repeatedString(s, n);
            return result;
        }
    }
}
