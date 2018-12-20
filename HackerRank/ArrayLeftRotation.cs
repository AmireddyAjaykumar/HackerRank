using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class ArrayLeftRotation
    {
        public static void PerformLeftRotation()
        {
            string[] nd = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = RotLeft(a, d);
            Console.WriteLine("Array after left rotation");
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] RotLeft(int[] a, int d)
        {
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < a.Length; i++)
            {
                que.Enqueue(a[i]);
            }
            for (int i = 0; i < d; i++)
            {
                int elem = que.Dequeue();
                que.Enqueue(elem);
            }
            int[] result = new int[que.Count];
            que.CopyTo(result, 0);
            return result;
        }
    }
}
