using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class PlusMinus
    {
        public static void PrintRatio()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }

        private static void plusMinus(int[] arr)
        {
            int length = arr.Length;
            int posCount = arr.Count(x => x > 0);
            int zeroCount = arr.Count(x => x == 0);
            int minCount = arr.Count(x => x < 0);
            List<decimal> list = new List<decimal>();
            list.Add(Decimal.Divide(posCount, length));
            list.Add(Decimal.Divide(minCount, length));
            list.Add(Decimal.Divide(zeroCount, length));
            foreach (var item in list)
            {
                Console.WriteLine("{0:n6}", item);
            }
        }
    }
}
