using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SuperMarketPriceInversions
    {
        // Complete the maxInversions function below.
        static long maxInversions(List<int> prices)
        {
            int[] arr = prices.ToArray();
            long count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallElemCount = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        smallElemCount++;
                    }
                }
                int greatElemCount = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] < arr[j])
                    {
                        greatElemCount++;
                    }
                }
                count += greatElemCount * smallElemCount;
            }
            return count;
        }

        public static void GetInversionCount()
        {
            int pricesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> prices = new List<int>();
            for (int i = 0; i < pricesCount; i++)
            {
                int pricesItem = Convert.ToInt32(Console.ReadLine().Trim());
                prices.Add(pricesItem);
            }
            long res = maxInversions(prices);
            Console.WriteLine(res);
        }
    }
}
