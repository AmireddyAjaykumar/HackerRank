using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class InsertionSort
    {
       static void SortElements(int[] numbers)
       {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j > 0; j--)
                {
                    if(numbers[j-1] > numbers[j])
                    {
                        numbers[j] = numbers[j] + numbers[j - 1];
                        numbers[j - 1] = numbers[j] - numbers[j - 1];
                        numbers[j] = numbers[j] - numbers[j - 1];
                    }
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
       }

        public static void Sort()
        {
            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };           
            Console.WriteLine("\nSorted Array Elements :");
            SortElements(numbers);
            Console.WriteLine("\n");
        }

        public static int[] InsertionSortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;
            }
            return inputArray;
        }
    }
}
