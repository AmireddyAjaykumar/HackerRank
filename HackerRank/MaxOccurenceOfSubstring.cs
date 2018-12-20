using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MaxOccurenceOfSubstring
    {
        public static string GetMostRepeatedSubstring()
        {
            string str = string.Empty;
            Console.WriteLine("Enter the string to search for repeated substring:");
            string input = Console.ReadLine().Trim();
            Console.WriteLine("Enter the substring length");
            int length = Convert.ToInt32(Console.ReadLine().Trim());
            str = GetRepeatedString(input, length);
            return str;
        }

        private static string GetRepeatedString(string input, int length)
        {
            string str = string.Empty;
            int max = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            if (input.Length > length)
            {
                for (int i = 0; i < input.Length - length; i++)
                {
                    string substr = input.Substring(i, length);
                    if (dict.ContainsKey(substr))
                    {
                        int count = ++dict[substr];
                        if (count > max)
                        {
                            max = count;
                            str = substr;
                        }
                    }
                    else
                    {
                        dict.Add(substr, 1);
                    }
                }
                if (max == 0)
                {
                    str = input.Substring(0, length);
                }

                foreach (var item in dict)
                {
                    Console.WriteLine(item.Key + " repeated " + item.Value + " times.");
                }
            }

            return str;
        }
    }
}
