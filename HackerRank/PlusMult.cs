using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class PlusMult
    {
        public static string plusMult(List<int> A)
        {
            int evenSum = A[0];
            int oddSum = A[1];
            bool isMult = true;

            for (int i = 2; i < A.Count; i += 2)
            {
                if (isMult)
                {
                    evenSum *= A[i];
                    isMult = false;
                }
                else
                {
                    evenSum += A[i];
                    isMult = true;
                }
            }

            isMult = true;
            for (int i = 3; i < A.Count; i += 2)
            {
                if (isMult)
                {
                    oddSum *= A[i];
                    isMult = false;
                }
                else
                {
                    oddSum += A[i];
                    isMult = true;
                }
            }
            if (evenSum % 2 > oddSum % 2)
                return "EVEN";
            if (evenSum % 2 < oddSum % 2)
                return "ODD";
            return "NEUTRAL";
        }

        public static void GetPlusMult()
        {
            int ACount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> A = new List<int>();
            for (int i = 0; i < ACount; i++)
            {
                int AItem = Convert.ToInt32(Console.ReadLine().Trim());
                A.Add(AItem);
            }
            string result = plusMult(A);
            Console.WriteLine(result);
        }

        //10
        //2
        //1456839280
        //4
        //785939584
        //37847848
        //4
        //457585977
        //947848339
        //748785785
        //757858699
    }
}
