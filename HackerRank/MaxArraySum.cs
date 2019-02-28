using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MaxArraySum
    {
        static int maxSubsetSum(int[] arr)
        {
            if (arr.Length == 0)
                return 0;
            arr[0] = Math.Max(0, arr[0]);
            if (arr.Length == 1)
                return arr[0];
            arr[1] = Math.Max(arr[0], arr[1]);
            for (int i = 2; i < arr.Length; i++)
                arr[i] = Math.Max(arr[i - 1], arr[i] + arr[i - 2]);
            return arr[arr.Length - 1];
        }

        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int res = maxSubsetSum(arr);
            Console.WriteLine(res);
        }
    }
}
