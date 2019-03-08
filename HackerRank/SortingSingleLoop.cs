using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SortingSingleLoop
    {
        public static void Sort()
        {
            int[] arr = { 5, 1, 7, 1, 3, 9 };

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] < arr[i - 1])
                {
                    arr[i] = arr[i] + arr[i - 1];
                    arr[i - 1] = arr[i] - arr[i - 1];
                    arr[i] = arr[i] - arr[i - 1];
                    i = 0;
                }

            }
            Console.WriteLine("Sorted Array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
