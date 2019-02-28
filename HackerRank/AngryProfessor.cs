using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class AngryProfessor
    {
        static string angryProfessor(int k, int[] a)
        {
            int onTimeCount = a.Count(x => x <= 0);
            if (onTimeCount < k)
                return "YES";
            return "NO";
        }

        public static void Execute()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(nk[0]);
                int k = Convert.ToInt32(nk[1]);
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
                string result = angryProfessor(k, a);
                Console.WriteLine(result);
            }
        }
    }
}