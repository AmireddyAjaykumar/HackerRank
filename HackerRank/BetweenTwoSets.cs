using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BetweenTwoSets
    {
        static int getTotalX(int[] a, int[] b)
        {
            /*
             * Write your code here.
             */
            int count = 0;
            List<int> list = new List<int>();
            for (int i = a[a.Length - 1]; i <= b[0]; i++)
            {
                bool isArrayOneFactor = true;
                foreach (var j in a)
                {
                    if (i % j != 0)
                    {
                        isArrayOneFactor = false;
                        break;
                    }                    
                }
                if (isArrayOneFactor)
                {
                    list.Add(i);
                }
            }
            foreach (var k in list)
            {
                bool isFactor = true;
                foreach (int x in b)
                {
                    if (x % k != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }
                if (isFactor)
                {
                    count++;
                }
            }
            return count;
        }

        public static void GetBetweenSetsCount()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
            int total = getTotalX(a, b);
            Console.WriteLine(total);
        }
    }
}
