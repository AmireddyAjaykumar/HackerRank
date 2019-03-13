using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class StringDistinctPermutations
    {
        static bool shouldSwap(char[] str, int start, int curr)
        {
            for (int i = start; i < curr; i++)
            {
                if (str[i] == str[curr])
                {
                    return false;
                }
            }
            return true;
        }

        static void findPermutations(char[] str, int index, int n)
        {
            if (index >= n)
            {
                Console.WriteLine(str);
                return;
            }
            for (int i = index; i < n; i++)
            {
                bool check = shouldSwap(str, index, i);
                if (check)
                {
                    swap(str, index, i);
                    //Console.WriteLine("After Swap \n" + string.Join("",str));
                    findPermutations(str, index + 1, n);
                    swap(str, index, i);
                    //Console.WriteLine("After Swap \n" + string.Join("",str));
                }
            }
        }

        static void swap(char[] str, int i, int j)
        {
            char c = str[i];
            str[i] = str[j];
            str[j] = c;
        }

        public static void Execute()
        {
            Console.WriteLine("Enter a word");
            char[] str = Console.ReadLine().Trim().ToCharArray();
            int n = str.Length;
            findPermutations(str, 0, n);
        }
    }
}
