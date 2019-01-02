using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class Kangaroo
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {  
            for (int i = 0; i < 10000; i++)
            {
                if ((x1 + v1 * i) == (x2 + v2 * i))
                {
                    return "YES";
                }
            }
            return "NO";
        }

        public static void CheckForSamePosition()
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(x1V1X2V2[0]);
            int v1 = Convert.ToInt32(x1V1X2V2[1]);
            int x2 = Convert.ToInt32(x1V1X2V2[2]);
            int v2 = Convert.ToInt32(x1V1X2V2[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
