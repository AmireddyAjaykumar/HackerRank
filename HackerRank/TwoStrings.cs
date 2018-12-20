using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class TwoStrings
    {
        public static void TwoStringsHaveCommonSubstrings()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string result = twoStrings(s1, s2);
                Console.WriteLine(result);
            }
        }

        private static string twoStrings(string s1, string s2)
        {          
            int index = s2.IndexOfAny(s1.ToCharArray());
            return index > -1 ? "YES" : "NO";
        }
    }
}
