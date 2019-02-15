using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class PickingNumbers
    {
        public static void GetSubArrayLength()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int result = GetResult(a);
            Console.WriteLine(result);
        }

        public static int GetResult(List<int> a)
        {            
            a.Sort();
            int maxCount = 0;
            for (int i = 0; i < a.Count - 1; i++)
            {
                int count = 1;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                    {
                        count++;
                    }
                }
                if (count > 1 && count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }
    }
}
