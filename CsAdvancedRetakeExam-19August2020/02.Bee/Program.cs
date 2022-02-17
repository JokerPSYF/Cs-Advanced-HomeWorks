using System;
using System.Linq;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int beeRow = default;
            int beeCol = default;
            int polinatedFlowers = 0;
            bool IsLost = false;
            bool IsBonusNotTaken = true;

            for (int rows = 0; rows < size; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                if (input.Contains('B'))
                {
                    beeRow = rows;
                }

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (input[cols] == 'B') beeCol = cols;
                }
            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                matrix[beeRow, beeCol] = '.';

                switch (cmd)
                {
                    case "up":
                        if (IsInRange(matrix, beeRow - 1, beeCol))
                        {
                            if (matrix[beeRow - 1, beeCol] == 'f')
                            {
                                polinatedFlowers++;
                            }
                            else if (matrix[beeRow - 1, beeCol] == 'O' && IsBonusNotTaken)
                            {
                                IsBonusNotTaken = false;
                                beeRow--;
                                matrix[beeRow, beeCol] = 'B';
                                continue;
                            }

                            beeRow--;
                            matrix[beeRow, beeCol] = 'B';
                        }
                        else IsLost = true;
                        break;

                    case "down":
                        if (IsInRange(matrix, beeRow + 1, beeCol))
                        {
                            if (matrix[beeRow + 1, beeCol] == 'f')
                            {
                                polinatedFlowers++;
                            }
                            else if (matrix[beeRow + 1, beeCol] == 'O' && IsBonusNotTaken)
                            {
                                IsBonusNotTaken = false;
                                beeRow++;
                                matrix[beeRow, beeCol] = 'B';
                                continue;
                            }

                            beeRow++;
                            matrix[beeRow, beeCol] = 'B';
                        }
                        else IsLost = true;
                        break;

                    case "left":
                        if (IsInRange(matrix, beeRow, beeCol - 1))
                        {
                            if (matrix[beeRow, beeCol - 1] == 'f')
                            {
                                polinatedFlowers++;
                            }
                            else if (matrix[beeRow, beeCol - 1] == 'O' && IsBonusNotTaken)
                            {
                                IsBonusNotTaken = false;
                                beeCol--;
                                matrix[beeRow, beeCol] = 'B';
                                continue;
                            }

                            beeCol--;
                            matrix[beeRow, beeCol] = 'B';
                        }
                        else IsLost = true;
                        break;

                    case "right":
                        if (IsInRange(matrix, beeRow, beeCol + 1))
                        {
                            if (matrix[beeRow, beeCol + 1] == 'f')
                            {
                                polinatedFlowers++;
                            }
                            else if (matrix[beeRow, beeCol + 1] == 'O' && IsBonusNotTaken)
                            {
                                IsBonusNotTaken = false;
                                beeCol++;
                                matrix[beeRow, beeCol] = 'B';
                                continue;
                            }

                            beeCol++;
                            matrix[beeRow, beeCol] = 'B';
                        }
                        else IsLost = true;
                        break;
                }

                if (IsLost) break;
                
                cmd = Console.ReadLine();
            }

            if (IsLost)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (polinatedFlowers >= 5) Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");

            else Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        static bool IsInRange(char[,] matrix, int row, int col)
            => row >= 0 && row < matrix.GetLength(0)
                        && col >= 0 && col < matrix.GetLength(1);
    }
}
