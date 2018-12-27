using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MiniMaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            long sum = 0, min = arr[0], max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine((sum - max) + " " + (sum - min));
        }

        public static void FindMiniMaxSum()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
