using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class JumpingOnClouds
    {
        static int jumpingOnClouds(int[] c, int n)
        {
            int steps = 0;
            if (c.Length == n)
            {
                for (int i = 0; i < c.Length;)
                {
                    int nextElem = -1;
                    int secondElem = -1;
                    if (i+1 < c.Length)
                    {
                        nextElem = c[i + 1];
                    }
                    if(i+2 < c.Length)
                    {
                        secondElem = c[i + 2];
                    }
                    if (secondElem == 0)
                    {
                        steps++;
                        i = i + 2;
                    }
                    else if (nextElem == 0)
                    {
                        steps++;
                        i = i + 1;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return steps;
        }

        public static int GetInput()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[] c = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), cTemp => Convert.ToInt32(cTemp));            ;
            int result = jumpingOnClouds(c, n);
            return result;
        }
    }
}
