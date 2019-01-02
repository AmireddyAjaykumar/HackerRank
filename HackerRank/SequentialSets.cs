using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SequentialSets
    {
        public static void SequenceSets()
        {
            Console.WriteLine("Enter array elements");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            printRanges(arr);
        }

        static void printRanges(int[] arr)
        {
            int start = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1] - 1)
                {
                    Console.WriteLine($"{start} {arr[i]}");
                    start = arr[i + 1];
                }
            }
            Console.WriteLine($"{start} {arr[arr.Length - 1]}");
        }
    }
}
