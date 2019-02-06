using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class ACMICPCTeam
    {
        static int[] acmTeam(string[] topic)
        {
            SortedDictionary<int, int> teams = new SortedDictionary<int, int>();
            ////List<int> lst = new List<int>();
            for (int i = 0; i < topic.Length - 1; i++)
            {
                string startPos = topic[i];
                for (int j = i+1; j < topic.Length; j++)
                {

                    string nextPos = topic[j];
                    int count = 0;
                    for (int k = 0; k < startPos.Length; k++)
                    {
                        if (startPos[k] == '1' || nextPos[k] == '1')
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("(" + (i + 1) + "," + (j + 1) + ")" + "-->" + count);
                    if (teams.ContainsKey(count))
                    {
                        teams[count]++;
                    }
                    else
                    {
                        teams.Add(count, 1);
                    }
                }
            }
            int[] arr = new int[2];
            arr[0] = teams.Max(x => x.Key);
            arr[1] = teams[arr[0]];
            return arr;
            //int count = 1, max = int.MinValue;
            //for (int i = 0; i < topic.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < topic.Length; j++)
            //    {
            //        int temp = 0;
            //        for (int k = 0; k < topic[i].Length; k++)
            //            if (topic[i][k] == '1' || topic[j][k] == '1')
            //                temp++;
            //        if (temp > max)
            //        {
            //            max = temp;
            //            count = 1;
            //        }
            //        else if (temp == max)
            //            count++;
            //    }
            //}
            //int[] ar = { max, count };
            //return ar;
        }

        public static void GetResult()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            string[] topic = new string[n];
            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic[i] = topicItem;
            }
            int[] result = acmTeam(topic);
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
