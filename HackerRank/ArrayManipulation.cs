using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class ArrayManipulation
    {
        public static void PrintMaxValeFromArray()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            int[][] queries = new int[m][];
            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }
            Console.WriteLine("Max element in array: " + arrayManipulation(n, queries));
        }

        private static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n];
            long max = 0;
            ////for (int i = 0; i < queries.Length; i++)
            ////{
            ////    int k = 0;
            ////    long startPos = queries[i][k];
            ////    long endPos = queries[i][k + 1];
            ////    long numAdd = queries[i][k + 2];
            ////    for (long j = startPos - 1; j < endPos; j++)
            ////    {
            ////        arr[j] += numAdd;
            ////        if(arr[j] > max)
            ////        {
            ////            max = arr[j];
            ////        }
            ////    }
            ////}
            ///
            for (int i = 0; i < queries.Length; i++)
            {
                int k = 0;
                int a = queries[i][k];
                int b = queries[i][k+1];
                int numAdd = queries[i][k+2];

                arr[a-1] += numAdd;
                if (b < n)
                {
                    arr[b] -= numAdd;
                }
                Console.WriteLine(string.Join(",", arr));
            }

            // track highest val seen so far as we go
            for (int i = 1; i < arr.Length; i++)
            {                
                arr[i] += arr[i - 1];
                Console.WriteLine("After Additon " + string.Join(",",arr));
                max = Math.Max(arr[i], max);
            }
            return max;
        }
    }
}
