using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class SocksMerchantProblem
    {
        static int sockMerchant(int n, int[] ar)
        {
            int[] disctinctElements = ar.Distinct().ToArray();
            int totalPairs = 0;
            foreach (int i in disctinctElements)
            {
                int count = ar.Count(x => x == i);
                totalPairs += count / 2;
            }
            return totalPairs;
        }

        public static int GetInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);           
            return result;
        }
    }
}
