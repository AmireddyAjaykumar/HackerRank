using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BubbleSort
    {
        static void countSwaps(int[] a)
        {
            int count = 0;
            bool isSorted = false;
            int lastSorted = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                isSorted = true;
                for (int j = 0; j < lastSorted; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        a[j] = a[j] + a[j + 1];
                        a[j + 1] = a[j] - a[j + 1];
                        a[j] = a[j] - a[j + 1];
                        count++;
                        isSorted = false;
                    }
                }
                lastSorted--;
                if (isSorted)
                {
                    break;
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.", count);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Length - 1]);
        }

        public static void GetSwapsCount()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            countSwaps(a);
        }
    }
}
