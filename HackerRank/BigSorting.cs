using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HackerRank
{
    public static class BigSorting
    {
        static string[] bigSorting(string[] unsorted)
        {
            Array.Sort(unsorted, (string a, string b) => {
                if (a.Length == b.Length)
                    return string.Compare(a, b, StringComparison.Ordinal);
                return a.Length - b.Length;
            });
            //BigInteger[] arr = new BigInteger[unsorted.Length];            
            //string[] arrStr = new string[unsorted.Length];
            //for (int i = 0; i < unsorted.Length; i++)
            //{
            //    arr[i] = BigInteger.Parse(unsorted[i]);
            //}
            //quickSort(arr, 0, unsorted.Length - 1);
            //arr = arr.OrderBy(x => x).ToArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arrStr[i] = arr[i].ToString();
            //}
            //return arrStr;
            return unsorted;
        }

        static int partition(BigInteger[] arr, int low, int high)
        {
            BigInteger pivot = arr[high];
            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;
                    // swap arr[i] and arr[j] 
                    BigInteger temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            // swap arr[i+1] and arr[high] (or pivot) 
            BigInteger temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }

        static void quickSort(BigInteger[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        public static void Sort()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted[i] = unsortedItem;
            }
            string[] result = bigSorting(unsorted);
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
