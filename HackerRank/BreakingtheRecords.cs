using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BreakingtheRecords
    {
        static int[] breakingRecords(int[] scores)
        {
            int[] maxMin = new int[2];
            int min = scores[0], max = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    maxMin[0]++;
                    max = scores[i];
                }
                if (scores[i] < min)
                {
                    maxMin[1]++;
                    min = scores[i];
                }
            }
            return maxMin;
        }

        public static void GetRecordBreakingCount()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
