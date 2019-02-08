using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BirthdayChocolate
    {
        static int birthday(List<int> s, int d, int m)
        {
            int[] arr = s.ToArray();
            int count = 0;
            for (int i = 0; i <= arr.Length - m; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += arr[j];
                }
                if (d == sum)
                {
                    count++;
                }
            }
            return count;
        }

        public static void GetResult()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            string[] dm = Console.ReadLine().TrimEnd().Split(' ');
            int d = Convert.ToInt32(dm[0]);
            int m = Convert.ToInt32(dm[1]);
            int result = birthday(s, d, m);
            Console.WriteLine(result);
        }
    }
}
