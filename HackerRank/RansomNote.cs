using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class RansomNote
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> notes = new Dictionary<string, int>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < note.Length; i++)
            {
                if (notes.ContainsKey(note[i]))
                {
                    notes[note[i]]++;
                }
                else
                {
                    notes.Add(note[i], 1);
                }
            }
            for (int i = 0; i < magazine.Length; i++)
            {
                if (dict.ContainsKey(magazine[i]))
                {
                    dict[magazine[i]]++;
                }
                else
                {
                    dict.Add(magazine[i], 1);
                }
            }
            foreach (var item in notes)
            {
                int count = 0;
                if (dict.ContainsKey(item.Key))
                {
                    count = dict[item.Key];
                }
                if(count >= item.Value)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }

        public static void CheckRansomNote()
        {
            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] note = Console.ReadLine().Split(' ');
            checkMagazine(magazine, note);
        }
    }
}
