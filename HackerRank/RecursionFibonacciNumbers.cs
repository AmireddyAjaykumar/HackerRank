using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class RecursionFibonacciNumbers
    {
        static int Fibonacci(int n)
        {
            int[] arr = new int[n + 2];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < n + 2; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }

        public static void GetNthFibonacciNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }
}
