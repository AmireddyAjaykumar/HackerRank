using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SherlockAndAnagrams
    {
        public static void GetAnagramsCount()
        {
            Console.WriteLine("Enter number of strings");
            int noOfStrings = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfStrings; i++)
            {
                string s = Console.ReadLine().Trim();
                int aCount = GetSherlockAndAnagrams(s);
                Console.WriteLine(aCount);
            }
        }

        private static int GetSherLockCount(string s)
        {
            int count = 0;           
            for (int k = 1; k < s.Length; k++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (i + k <= s.Length && j + k <= s.Length)
                        {
                            string str1 = s.Substring(i, k);
                            string str2 = s.Substring(j, k);

                            Dictionary<char, int> valuePairs = new Dictionary<char, int>();
                            Dictionary<char, int> values = new Dictionary<char, int>();
                            for (int c = 0; c < str1.Length; c++)
                            {
                                if (valuePairs.ContainsKey(str1[c]))
                                {
                                    valuePairs[str1[c]]++;
                                }
                                else
                                {
                                    valuePairs.Add(str1[c], 1);
                                }
                            }
                            for (int c = 0; c < str2.Length; c++)
                            {
                                if (values.ContainsKey(str2[c]))
                                {
                                    values[str2[c]]++;
                                }
                                else
                                {
                                    values.Add(str2[c], 1);
                                }
                            }
                            bool isEqual = true;
                            foreach (var item in values)
                            {
                                if(!valuePairs.Contains(item) || valuePairs[item.Key] != values[item.Key])
                                {
                                    isEqual = false;
                                }
                            }


                            ////char[] chars1 = str1.ToCharArray();
                            ////char[] chars2 = str2.ToCharArray();
                            //Array.Reverse(chars);
                            //string revStr = new String(chars);
                            ////bool isEqual = false;
                            ////if (chars1.Length == chars2.Length)
                            ////{
                            ////    foreach (var item in chars1)
                            ////    {
                            ////        if()
                            ////    }
                            ////}

                            ////var isEqual = new HashSet<char>(chars1).SetEquals(chars2);
                            if (str1 == str2 || isEqual)
                            {
                                ////Console.WriteLine("[" + i + "," + j + "]");
                                Console.WriteLine(str1 + " " + str2);
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

        private static int GetSherlockAndAnagrams(string s)
        {
            var count = 0;
            for (var l = 1; l <= s.Length; l++)
            {
                for (var i = 0; i < s.Length - l; i++)
                {
                    var a1 = s.Substring(i, l).ToCharArray();
                    Array.Sort(a1);
                    for (var j = i + 1; j <= s.Length - l; j++)
                    {
                        var a2 = s.Substring(j, l).ToCharArray();
                        Array.Sort(a2);

                        var anagram = true;
                        for (var n = 0; n < a1.Length; n++)
                        {
                            if (a1[n] != a2[n])
                            {
                                anagram = false;
                                break;
                            }
                        }

                        if (anagram) { count++; }
                    }
                }
            }
            return count;
        }
    }
}
