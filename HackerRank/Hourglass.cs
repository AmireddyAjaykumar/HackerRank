using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class Hourglass
    {
        public static int FindHourGlassWithMaximumSum()
        {
            int sum = 0;
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            sum = GetMaxHourGlassSum(arr);
            return sum;
        }

        private static int GetMaxHourGlassSum(int[][] arr)
        {
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (sum > max)
                    {
                        max = sum;
                    }
                }                
            }
            return max;
        }
    }
}
