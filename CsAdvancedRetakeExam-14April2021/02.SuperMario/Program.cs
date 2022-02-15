using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int hearts = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            int[] marioPosition = new int[2];

            int[] peachPosition = new int[2];

            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                if (matrix[i].Contains('P'))
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 'P')
                        {
                            peachPosition[0] = i;
                            peachPosition[1] = j;
                        }
                    }
                }
                else if (matrix[i].Contains('M'))
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 'M')
                        {
                            marioPosition[0] = i;
                            marioPosition[1] = j;
                        }
                    }
                }
            }

            while (hearts > 0)
            {
                string[] cmd = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int bowserRow = int.Parse(cmd[1]);
                int bowserCol = int.Parse(cmd[2]);

                if (IsInRange(matrix, bowserRow, bowserCol))
                {
                    matrix[bowserRow][bowserCol] = 'B';
                }

                matrix[marioPosition[0]][marioPosition[1]] = '-';
                hearts--;

                switch (cmd[0])
                {
                    case "W":
                        if (IsInRange(matrix, marioPosition[0] - 1, marioPosition[1]))
                        {
                            marioPosition[0]--;

                            if (matrix[marioPosition[0]][marioPosition[1]] == 'B')
                            {
                                if (hearts <= 2)
                                {
                                    hearts = 0;
                                }
                                else
                                {
                                    hearts -= 2;
                                }
                            }
                        }
                        break;

                    case "S":
                        if (IsInRange(matrix, marioPosition[0] + 1, marioPosition[1]))
                        {
                            marioPosition[0]++;

                            if (matrix[marioPosition[0]][marioPosition[1]] == 'B')
                            {
                                if (hearts <= 2)
                                {
                                    hearts = 0;
                                }
                                else
                                {
                                    hearts -= 2;
                                }
                            }
                        }
                        break;

                    case "A":
                        if (IsInRange(matrix, marioPosition[0], marioPosition[1] - 1))
                        {
                            marioPosition[1]--;

                            if (matrix[marioPosition[0]][marioPosition[1]] == 'B')
                            {
                                if (hearts <= 2)
                                {
                                    hearts = 0;
                                }
                                else
                                {
                                    hearts -= 2;
                                }
                            }
                        }
                        break;

                    case "D":
                        if (IsInRange(matrix, marioPosition[0], marioPosition[1] + 1))
                        {
                            marioPosition[1]++;

                            if (matrix[marioPosition[0]][marioPosition[1]] == 'B')
                            {
                                if (hearts <= 2)
                                {
                                    hearts = 0;
                                }
                                else
                                {
                                    hearts -= 2;
                                }
                            }
                        }
                        break;
                }

                if (hearts <= 0)
                {
                    matrix[marioPosition[0]][marioPosition[1]] = 'X';
                    break;
                }
                matrix[marioPosition[0]][marioPosition[1]] = 'M';


                if (marioPosition[0] == peachPosition[0] && marioPosition[1] == peachPosition[1])
                {
                    matrix[marioPosition[0]][marioPosition[1]] = '-';

                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {hearts}");

                    PrintMatrix(matrix);

                    return;
                }
            }

            Console.WriteLine($"Mario died at {marioPosition[0]};{marioPosition[1]}.");
            PrintMatrix(matrix);
        }

        static bool IsInRange(char[][] matrix, int row, int col)
            => row >= 0 && row < matrix.GetLength(0)
                        && col < matrix[row].Length && col >= 0;

        static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
