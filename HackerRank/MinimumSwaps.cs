using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MinimumSwaps
    {
        public static void PrintMinimumSwaps()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int res = SelectionSort(arr);
            Console.WriteLine("Minimum Swaps rquired is " + res);
        }

        private static int SelectionSort(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != i + 1)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == i+1)
                        {
                            arr[j] = arr[i];
                            arr[i] = i + 1;
                            count++;
                            break;
                        }
                    }                    
                }
            }
            return count;
        }

        private static int SortSelection(int[] arr)
        {
            int tmp, min_key, count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min_key = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_key])
                    {
                        min_key = j;
                    }
                }
                tmp = arr[min_key];
                arr[min_key] = arr[i];
                arr[i] = tmp;
                if (min_key != i)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
