using System;
using System.Collections.Generic;

namespace HackerRank
{
    public static class ShortestPathAlgorithmAmazon
    {
        public static void GetShortestPath()
        {
            int[,] mat = { { 1, 0, 0 },
                           { 1, 1, 0 },
                           { 0, 1, 9 }
                         };

            int size = mat.GetLength(0);

            int x = 0, y = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (mat[i, j] == 9)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
            }

            Console.WriteLine(ShortestPath(mat, (0, 0), (x, y), size));
            Console.ReadLine();
        }

        static int ShortestPath(int[,] mat, (int, int) u, (int, int) v, int n)
        {
            // visited[n] for keeping track of visited nodes
            bool[,] visited = new bool[n, n];

            // Initialize distances as 0
            int[,] distance = new int[n, n];

            // queue to do BFS.
            Queue<(int, int)> Q = new Queue<(int, int)>();
            distance[u.Item1, u.Item2] = 0;

            Q.Enqueue(u);
            visited[u.Item1, u.Item2] = true;
            while (Q.Count > 0)
            {
                var x = Q.Dequeue();
                int i = x.Item1;
                int j = x.Item2;

                //break code
                if (mat[i, j] == 9)
                    break;

                if (i + 1 < n && mat[i + 1, j] != 0 && !visited[i + 1, j])
                {
                    distance[i + 1, j] = distance[i, j] + 1;
                    Q.Enqueue((i + 1, j));
                    visited[i + 1, j] = true;
                }
                if (j + 1 < n && mat[i, j + 1] != 0 && !visited[i, j + 1])
                {
                    distance[i, j + 1] = distance[i, j] + 1;
                    Q.Enqueue((i, j + 1));
                    visited[i, j + 1] = true;
                }
                if (i - 1 >= 0 && mat[i - 1, j] != 0 && !visited[i - 1, j])
                {
                    distance[i - 1, j] = distance[i, j] + 1;
                    Q.Enqueue((i - 1, j));
                    visited[i - 1, j] = true;
                }
                if (j - 1 >= 0 && mat[i, j - 1] != 0 && !visited[i, j - 1])
                {
                    distance[i, j - 1] = distance[i, j] + 1;
                    Q.Enqueue((i, j - 1));
                    visited[i, j - 1] = true;
                }
            }
            return distance[v.Item1, v.Item2];
        }
    }
}