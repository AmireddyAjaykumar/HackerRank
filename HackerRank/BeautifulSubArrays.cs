using System;

namespace HackerRank
{
    public static class BeautifulSubArrays
    {
        public static int countSubarrays(int[] a,
                                int n, int m)
        {
            int count = 0;
            int[] prefix = new int[n];
            int odd = 0;

            // traverse in the array 
            for (int i = 0; i < n; i++)
            {
                prefix[odd]++;

                // if array element is odd 
                if ((a[i] & 1) == 1)
                    odd++;

                // when number of odd  
                // elements >= M 
                if (odd >= m)
                    count += prefix[odd - m];
            }

            return count;
        }

        // Driver code 
        public static void GetBeautifulSubArrays()
        {
            Console.WriteLine("Enter Array");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int n = a.Length;
            Console.WriteLine("Enter Odd Count in SubArray");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                      countSubarrays(a, n, m));
        }
    }
}
