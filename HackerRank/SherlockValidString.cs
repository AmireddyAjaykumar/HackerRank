using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class SherlockValidString
    {
        static string isValid(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            var d = dict.GroupBy(x => x.Value).Select(y => new { key = y.Key, count = y.Count()}).OrderBy(x => x.key).ToList();
            //int max = dict.Max(x => x.Value);
            //int minCount = dict.Count(x => x.Value == min);
            //int count = d.Values.Distinct().Count();
            //if (count > 2)
            //    return "NO";
            //else if (count == 2)
            //{
            //    if (d.Keys.ElementAt(0) != d.Keys.ElementAt(1) && (d.Keys.ElementAt(0) - 1 != d.Keys.ElementAt(1)) ||
            //        (d.Keys.ElementAt(0) - 1 == d.Keys.ElementAt(1) &&
            //        (d.Values.ElementAt(1) != 1 && d.Values.ElementAt(0) != 1)))
            //    {
            //        return "NO";
            //    }
            //}
            //if (minCount == 1 && min + 1 == max)
            //    return "YES";
            ////return "YES";
        //    var groups = s
        //.GroupBy(c => c)
        //.Select(grp => grp.Count())
        //.GroupBy(c => c)
        //.OrderBy(grp => grp.Key)
        //.Select(c => new { K = c.Key, N = c.Count() })
        //.ToList();

            var min = d.First();
            var max = d.Last();
            var count = d.Count();

            if (count == 1)
                return "YES";
            else if (count > 2)
                return "NO";
            else if (min.key == 1 && min.count == 1)
                return "YES";
            else if (max.count == 1 && max.key == min.key + 1)
                return "YES";
            else
                return "NO";
        }

        public static void CheckSherlockValidString()
        {
            string s = Console.ReadLine();
            string result = isValid(s);
            Console.WriteLine(result);
        }
    }
}
