using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] values = Console.ReadLine().Split(' ');

            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(value[j]);
                }
            }

            Console.WriteLine("Please enter a number that is contained in the matrix: ");
            int n1 =  int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i, j] == n1)
                    {
                        Console.WriteLine($"Position {i},{j}:");

                        if(j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i - 1, j]}");
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }

    }
}
