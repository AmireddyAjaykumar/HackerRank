using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class LeadLife
    {
        public static void Execute()
        {
            int[] earnings = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] costs = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MaxEarning(earnings, costs, e));
        }

        public static int MaxEarning(int[] earnings, int[] costs, int e)
        {
            int maxEarn = 0;
            int prevIndex = -1;
            bool haveEnergy = true;
            //costs[costs.Length - 1] = 0;

            for (int i = 0; i < earnings.Length; i++)
            {
                //if (earnings[i] > costs[i])
                //{
                    if (!haveEnergy && earnings[i] > costs[prevIndex])
                    {
                        maxEarn -= (costs[prevIndex]) * e;
                        haveEnergy = true;
                    }

                    if (haveEnergy && prevIndex != -1 && earnings[i] > costs[prevIndex])
                    {
                        maxEarn += earnings[i] * e;
                        haveEnergy = false;
                    }
                    prevIndex = i;
                //}
            }
           
            return maxEarn;
        }
    }
}
