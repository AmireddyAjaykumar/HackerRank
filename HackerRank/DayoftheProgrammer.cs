using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class DayoftheProgrammer
    {
        static string dayOfProgrammer(int year)
        {
            // for all cases after 1918 as I am starting from 1st day of year
            int daysToAdjust = 255;

            if (year == 1918)
            {
                // this is the year they turned to gregorian calendar
                daysToAdjust = daysToAdjust + 13;
            }

            else if (year < 1918)
            {
                // jullian calendar only divide by 4 for leap year, where as gregorian excludes divide by 100 case
                if (year % 4 == 0 && year % 100 == 0)
                {
                    daysToAdjust = daysToAdjust - 1;
                }
            }

            DateTime date = new DateTime(year, 1, 1);
            DateTime dayOfProgrammer = date.AddDays(daysToAdjust);
            return dayOfProgrammer.ToString("dd.MM.yyyy");
        }

        public static void GetDayOfTheProgrammer()
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());
            string result = dayOfProgrammer(year);
            Console.WriteLine(result);
        }
    }
}
