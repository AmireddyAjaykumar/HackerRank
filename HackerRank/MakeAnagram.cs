using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MakeAnagram
    {
        static int makeAnagram(string a, string b)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i <= 'z' - 'a'; i++)
            {
                d.Add(i, 0);
            }

            foreach (char c in a)
            {
                d[c - 'a']++;
            }
            foreach (char c in b)
            {
                d[c - 'a']--;
            }

            return d.Sum(x => Math.Abs(x.Value));
        }

        public static void GetNoOfDeletions()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int res = makeAnagram(a, b);
            Console.WriteLine(res);
        }
    }
}
