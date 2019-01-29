using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class TimeGapBetweenMeetings
    {
        public static int LongestTimeSlot()
        {
            string S = "Mon 01:00-23:00\nTue 01:00-23:00\n"+
                        "Wed 01:00-23:00\nThu 01:00-23:00\nFri 01:00-23:00\nSat 01:00-23:00\n"+
                        "Sun 01:00-21:00";
            List<double> diff = new List<double>();


            Dictionary<string, int> valuePairs = new Dictionary<string, int>() {
                { "Mon", 1 },
                { "Tue", 2 },
                { "Wed", 3 },
                { "Thu", 4 },
                { "Fri", 5 },
                { "Sat", 6 },
                { "Sun", 7 }
            };

            string[] lines = S.Split('\n');
            SortedDictionary<int, SortedDictionary<DateTime, DateTime>> times = new SortedDictionary<int, SortedDictionary<DateTime, DateTime>>();
            foreach (string line in lines)
            {
                string[] arr = line.Split(' ');
                string[] t = arr[1].Split('-');
                DateTime currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                double t01 = Convert.ToDouble(t[0].Substring(0, 2));
                double t02 = Convert.ToDouble(t[0].Substring(3));
                double t11 = Convert.ToDouble(t[1].Substring(0, 2));
                double t12 = Convert.ToDouble(t[1].Substring(3));
                if (times.ContainsKey(valuePairs[arr[0]]))
                {
                    times[valuePairs[arr[0]]].Add(currentDate.AddHours(t01).AddMinutes(t02).AddDays(valuePairs[arr[0]]), 
                        currentDate.AddHours(t11).AddMinutes(t12).AddDays(valuePairs[arr[0]]));
                }
                else
                {
                    SortedDictionary<DateTime, DateTime> sortedTimes = new SortedDictionary<DateTime, DateTime>();
                    sortedTimes.Add(currentDate.AddHours(t01).AddMinutes(t02).AddDays(valuePairs[arr[0]]),
                        currentDate.AddHours(t11).AddMinutes(t12).AddDays(valuePairs[arr[0]]));
                    times.Add(valuePairs[arr[0]], sortedTimes);
                }
            }

            DateTime dt = times.First().Value.First().Value;
            times.First().Value.Remove(times.First().Value.First().Key);
            foreach (var item in times)
            {
                foreach (var time in item.Value)
                {
                    diff.Add((time.Key - dt).TotalMinutes);
                    dt = time.Value;
                }
            }
            DateTime eod = new DateTime(dt.Year, dt.Month, dt.Day + 1, 0, 0, 0);
            diff.Add((eod - dt).TotalMinutes);

            return Convert.ToInt32(diff.Max());
        }
    }
}
