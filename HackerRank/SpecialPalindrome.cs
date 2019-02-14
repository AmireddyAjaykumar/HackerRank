using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SpecialPalindrome
    {
        static long substrCount(int n, string s)
        {
            long count = s.Length;
            //for (int i = 2; i <= s.Length; i++)
            //{
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if (i + j <= s.Length)
            //        {
            //            string subStr = s.Substring(j, i);
            //            Console.WriteLine(subStr);
            //            int distCount = subStr.ToCharArray().Distinct().Count();
            //            int charCount = subStr.ToCharArray().Count(x => x == subStr[0]);
            //            if (subStr.Length == 1)
            //            {
            //                count++;
            //            }
            //            else if (subStr.Length > 1 && subStr.Length % 2 != 0 && (distCount == 1 || 
            //                (distCount > 1 && charCount == subStr.Length - 1)))
            //            {
            //                count++;
            //            }
            //            else if (subStr.Length > 1 && subStr.Length % 2 == 0 && charCount == subStr.Length)
            //            {
            //                count++;
            //            }


            //            //for(int c = 0; c < subStr.Length; c++)
            //            //{
            //            //    if(subStr.Length % 2 != 0 && c != subStr[subStr.Length/2] && subStr[c] == subStr[subStr.Length - c])
            //            //    {
            //            //        count++;
            //            //    }
            //            //    if(subStr.Length % 2 == 0 && subStr[c] == subStr[subStr.Length - c])
            //            //    {
            //            //        count++;
            //            //    }
            //            //}
            //            //string revStr = string.Empty;
            //            //for (int k = subStr.Length - 1; k >= 0; k--)
            //            //{
            //            //    revStr += subStr[k];
            //            //}
            //            //if (subStr == revStr)
            //            //{
            //            //    count++;
            //            //}
            //        }
            //    }
            //}
            for (int i = 0; i < s.Length; i++)
            {
                var startChar = s[i];
                int diffCharIdx = -1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    var currChar = s[j];
                    if (startChar == currChar)
                    {
                        if ((diffCharIdx == -1) ||
                           (j - diffCharIdx) == (diffCharIdx - i))
                            count++;
                    }
                    else
                    {
                        if (diffCharIdx == -1)
                            diffCharIdx = j;
                        else
                            break;
                    }
                }
            }
            return count;
        }

        public static void GetSpecialPalindromeCount()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            long result = substrCount(n, s);
            Console.WriteLine(result);
        }
    }
}
