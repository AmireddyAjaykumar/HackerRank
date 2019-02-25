using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class DiamondMine
    {

        static int inf = 100000;

        //public static void solve()
        //{
        //    long i, j;
        //    if (d[0, 0] != -1)
        //    {
        //        ans[0, 0] = d[0, 0];
        //        prev[0, 0] = (-1, -1);
        //    }
        //    for (i = 1; i < n; i++)
        //    {
        //        if (d[0, i] == -1)
        //            break;
        //        ans[0, i] = ans[0, i - 1] + d[0, i];
        //        prev[0, i] = (0, i - 1);
        //    }
        //    while (i < n)
        //    {
        //        ans[0, i] = -1;
        //        i++;
        //    }
        //    for (i = 1; i < n; i++)
        //    {
        //        if (d[i, 0] == -1)
        //            break;
        //        ans[i, 0] = ans[i - 1, 0] + d[i, 0];
        //        prev[i, 0] = (i - 1, 0);
        //    }
        //    while (i < n)
        //    {
        //        ans[i, 0] = -1;
        //        i++;
        //    }
        //    for (i = 1; i < n; i++)
        //    {
        //        for (j = 1; j < n; j++)
        //        {
        //            if (d[i, j] == -1)
        //            {
        //                ans[i, j] = -1;
        //                continue;
        //            }
        //            if (ans[i - 1, j] > ans[i, j - 1])
        //            {
        //                ans[i, j] = ans[i - 1, j] + d[i, j];
        //                prev[i, j] = (i - 1, j);
        //            }
        //            else
        //            {
        //                ans[i, j] = ans[i, j - 1] + d[i, j];
        //                prev[i, j] = (i, j - 1);
        //            }
        //        }
        //    }
        //}
        //static void update()
        //{
        //    long i, j;
        //    (long, long) node;
        //    i = n - 1;
        //    j = n - 1;
        //    while (i != -1 && j != -1)
        //    {
        //        node = prev[i, j];
        //        d[i, j] = 0;
        //        i = node.Item1;
        //        j = node.Item2;
        //    }
        //}
        //static void init()
        //{
        //    long i, j;
        //    for (i = 0; i < n; i++)
        //    {
        //        for (j = 0; j < n; j++)
        //        {
        //            ans[i, j] = 0;
        //        }
        //    }
        //}

        // Calculating the points at a (row1, col1) &&  
        // (row2, col2) from path1 && path2 
        private static int cost(List<List<int>> grid, int row1, int col1, int row2, int col2)
        {
            // If both path is at same cell 
            if (row1 == row2 && col1 == col2)
            {

                // If the cell contain *, return 1 
                if (grid[row1][col1] == 1)
                {
                    return 1;
                }

                // else return 0. 
                return 0;
            }

            int ans = 0;

            // If path 1 contain *, add to answer. 
            if (grid[row1][col1] == 1)
            {
                ans++;
            }

            // If path  contain *, add to answer. 
            if (grid[row2][col2] == 1)
            {
                ans++;
            }

            return ans;
        }

        // Calculate the maximum points that can be 
        // collected. 
        private static int solve(int n, int m, List<List<int>> grid, int[][][] dp, int row1, int col1, int row2)
        {
            int col2 = (row1 + col1) - (row2);

            // If both path reach the bottom right cell 
            if (row1 == n - 1 && col1 == m - 1 && row2 == n - 1 && col2 == m - 1)
            {
                return 0;
            }

            // If moving out of grid 
            if (row1 >= n || col1 >= m || row2 >= n || col2 >= m)
            {
                return -1 * inf;
            }

            // If already calculated, return the value 
            if (dp[row1][col1][row2] != -1)
            {
                return dp[row1][col1][row2];
            }

            // Vaiable for 4 options. 
            int ch1 = -1 * inf;
            int ch2 = -1 * inf;
            int ch3 = -1 * inf;
            int ch4 = -1 * inf;

            // If path 1 is moving right and path 2  
            // is moving down. 
            if (col1 + 1 < dp.GetLength(0) && grid[row1][col1 + 1] != -1 && row2 + 1 < dp.GetLength(0) && grid[row2 + 1][col2] != -1)
            {
                ch1 = cost(grid, row1, col1 + 1, row2 + 1, col2) + solve(n, m, grid, dp, row1, col1 + 1, row2 + 1);
            }

            // If path 1 is moving right and path 2 is moving 
            // right. 
            if (col1 + 1 < dp.GetLength(0) && grid[row1][col1 + 1] != -1 && col2 + 1 < dp.GetLength(0) && grid[row2][col2 + 1] != -1)
            {
                ch2 = cost(grid, row1, col1 + 1, row2, col2 + 1) + solve(n, m, grid, dp, row1, col1 + 1, row2);
            }

            // If path 1 is moving down and path 2 is moving right. 
            if (row1 + 1 < dp.GetLength(0) && grid[row1 + 1][col1] != -1 && col2 + 1 < dp.GetLength(0) && grid[row2][col2 + 1] != -1)
            {
                ch3 = cost(grid, row1 + 1, col1, row2, col2 + 1) + solve(n, m, grid, dp, row1 + 1, col1, row2);
            }

            // If path 1 is moving down and path 2 is moving down. 
            if (row1 + 1 < dp.GetLength(0) && grid[row1 + 1][col1] != -1 && row2 + 1 < dp.GetLength(0) && grid[row2 + 1][col2] != -1)
            {
                ch4 = cost(grid, row1 + 1, col1, row2 + 1, col2) + solve(n, m, grid, dp, row1 + 1, col1, row2 + 1);
            }

            // Returning the maximum of 4 options. 
            return dp[row1][col1][row2] = Math.Max(ch1, Math.Max(ch2, Math.Max(ch3, ch4)));
        }


        // Wrapper Function 
        private static int collectMax(int n, int m, List<List<int>> grid)
        {
            int ans = 0;
            int[][][] dp = RectangularArrays.RectangularIntArray(m,m,m);
            //C++ TO C# CONVERTER TODO TASK: The memory management function 'memset' has no equivalent in C#:
            dp = Memset(dp, -1);

            // If last bottom right cell is blcoked 
            if (grid[n - 1][m - 1] == -1 || grid[0][0] == -1)
            {
                ans = -1 * inf;
            }

            // If top left cell contain * 
            if (grid[0][0] == 1)
            {
                ans++;
            }
            grid[0][0] = 0;

            // If bottom right cell contain * 
            if (grid[n - 1][m - 1] == 1)
            {
                ans++;
            }
            grid[n - 1][m - 1] = 0;

            ans += solve(n, m, grid, dp, 0, 0, 0);
            return Math.Max(ans, 0);
        }

        public static void GetDiamondCount()
        {
            int matRows = Convert.ToInt32(Console.ReadLine().Trim());
            int matColumns = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> mat = new List<List<int>>();
            for (int i = 0; i < matRows; i++)
            {
                mat.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matTemp => Convert.ToInt32(matTemp)).ToList());
            }
            int result = collectMax(matRows, matColumns, mat);
            Console.WriteLine(result);
        }

        public static int[][][] Memset(int[][][] array, int elem)
        {
            int length = array.Length;
            if (length == 0) return array;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int k = 0; k < array.GetLength(0); k++)
                    {
                        array[i][j][k] = -1;
                    }
                }
            }
            return array;
        }
    }

    internal static class RectangularArrays
    {
        public static int[][][] RectangularIntArray(int size1, int size2, int size3)
        {
            int[][][] newArray = new int[size1][][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new int[size2][];
                if (size3 > -1)
                {
                    for (int array2 = 0; array2 < size2; array2++)
                    {
                        newArray[array1][array2] = new int[size3];
                    }
                }
            }

            return newArray;
        }
    }
}
