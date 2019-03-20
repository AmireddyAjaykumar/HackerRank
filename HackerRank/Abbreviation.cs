using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class Abbreviation
    {
        static string abbreviation(string a, string b)
        {
            //List<char> list = new List<char>();
            //foreach (char c in a)
            //{
            //    int asci = (int)c;
            //    if (asci > 96 && asci < 123 &&  b.IndexOf(c.ToString().ToUpper()) != -1)
            //    {
            //        list.Add(c);
            //    }
            //    else if(asci > 64 && asci < 91)
            //    {
            //        list.Add(c);
            //    }
            //}
            //if (list.Count == b.Length && string.Compare(string.Join("",list), b, true) == 0)
            //{
            //    return "YES";
            //}
            //return "NO";
            //bool[,] dp = new bool[b.Length + 1, a.Length + 1];
            //dp[0,0] = true;
            //for (int j = 1; j <dp.GetLength(0); j++)
            //{
            //    if (Char.IsLower(a[j - 1]))
            //        dp[0,j] = dp[0,j - 1];
            //}
            //for (int i = 1; i < dp.GetLength(0); i++)
            //{
            //    for (int j = 1; j < dp.GetLength(0); j++)
            //    {
            //        char ca = a[j - 1], cb = b[i - 1];
            //        if (ca >= 'A' && ca <= 'Z')
            //        {
            //            if (ca == cb)
            //            {
            //                dp[i,j] = dp[i - 1,j - 1];
            //            }
            //        }
            //        else
            //        {
            //            ca = Char.ToUpper(ca);
            //            if (ca == cb)
            //                dp[i,j] = dp[i - 1,j - 1] || dp[i,j - 1];
            //            else
            //                dp[i,j] = dp[i,j - 1];
            //        }
            //    }
            //}

            //return dp[b.Length,a.Length] ? "YES" : "NO";

            if (a == null && b == null)
            {
                return "YES";
            }
            if ((a == null && b != null) || (a != null && b == null))
            {
                return "NO";
            }
            int bIt = 0;
            int aIt;
            for (aIt = 0; aIt < a.Length; aIt++)
            {
                if (bIt >= b.Length)
                {
                    break;
                }
                char aChar = a[aIt];
                char bChar = b[bIt];
                if ((aChar == bChar) || (char.ToUpper(aChar) == bChar))
                {
                    bIt++;
                    continue;
                }
                else if (Char.IsLower(aChar))
                {
                    continue;
                }
                else
                {
                    return "NO";
                }
            }
            if (aIt != a.Length)
            {
                for (; aIt < a.Length; aIt++)
                {
                    char aChar = a[aIt];
                    if (!Char.IsLower(aChar))
                    {
                        return "NO";
                    }
                }
            }
            if ((bIt != b.Length))
            {
                return "NO";
            }
            return "YES";
        }

        public static void Execute()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int qItr = 0; qItr < q; qItr++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = abbreviation(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
