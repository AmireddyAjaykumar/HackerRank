using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class IntroToChallenges
    {
        static int introTutorial(int V, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == V)
                {
                    return i;
                }
            }
            return 0;
        }

        public static void GetIndex()
        {
            int V = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = introTutorial(V, arr);
            Console.WriteLine(result);
        }
    }
}
