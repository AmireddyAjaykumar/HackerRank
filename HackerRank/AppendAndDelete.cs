using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class AppendAndDelete
    {
        static string appendAndDelete(string s, string t, int k)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            int i = 0;
            for (; i < sArray.Length && i < tArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                {
                    break;
                }
            }
            int numOfMinOperations = (s.Length + t.Length) - (2 * i);
            return ((numOfMinOperations <= k && (k - numOfMinOperations) % 2 == 0) || s.Length + t.Length < k) ? "Yes" : "No";

        }

        public static void GetResult()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = appendAndDelete(s, t, k);
            Console.WriteLine(result);
        }
    }
}
