using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class CountTriplets
    {
        public static void GetTripletsCount()
        {
            string[] nr = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nr[0]);
            long r = Convert.ToInt64(nr[1]);
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
            long ans = countTriplets(arr, r);
            Console.WriteLine(ans);
        }

        private static long countTriplets(List<long> arr, long r)
        {
            long count = 0;
            Dictionary<long, long> dict = new Dictionary<long, long>();
            Dictionary<long, long> dictPairs = new Dictionary<long, long>();

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                long key = arr[i] * r;
                if (dictPairs.ContainsKey(key))
                    count += dictPairs[key];

                if (dict.ContainsKey(key))
                {
                    if (dictPairs.ContainsKey(arr[i]))
                        dictPairs[arr[i]] += dict[key];
                    else
                        dictPairs[arr[i]] = dict[key];
                }

                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 1);
                else
                    dict[arr[i]]++;
            }

            return count;
        }

        private static long TripletsCount(List<long> arr, long r)
        {           
            long count = 0, c = arr.Count;
            Dictionary<long, long> d = new Dictionary<long, long>();
            long[] left = new long[c];
            long[] nonRight = new long[c];
            for (int i = 0; i < c; i++)
            {
                if (arr[i] % r == 0 && d.ContainsKey(arr[i] / r))
                    left[i] = d[arr[i] / r];
                if (d.ContainsKey(arr[i]))
                    d[arr[i]]++;
                else
                    d.Add(arr[i], 1);
                if (d.ContainsKey(arr[i] * r))
                    nonRight[i] = d[arr[i] * r];
            }
            for (int i = 1; i < c - 1; i++)
            {
                if (d.ContainsKey(arr[i] * r))
                    count += left[i] * (d[arr[i] * r] - nonRight[i]);
            }
            return count;           
        }
    }
}
