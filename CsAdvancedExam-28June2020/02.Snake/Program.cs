using System;
using System.Linq;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int food = 0;

            int snakeRow = default;

            int snakeCol = default;

            int firstBorrowRow = default;

            int firstBorrowCol = default;

            int secondBorrowRow = default;

            int secondBorrowCol = default;

            bool IsLost = false;

            for (int rows = 0; rows < size; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                if (input.Contains('S'))
                {
                    snakeRow = rows;
                }

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (input[cols] == 'S') snakeCol = cols;

                    if (input[cols] == 'B')
                    {
                        if (firstBorrowRow == default)
                        {
                            firstBorrowRow = rows;
                            firstBorrowCol = cols;
                        }
                        else
                        {
                            secondBorrowRow = rows;
                            secondBorrowCol = cols;
                        }
                    }
                }
            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                matrix[snakeRow, snakeCol] = '.';

                switch (cmd)
                {
                    case "up":
                        if (IsInRange(matrix, snakeRow - 1, snakeCol))
                        {
                            if (matrix[snakeRow - 1, snakeCol] == '*') { food++; snakeRow--; }

                            else if (snakeRow - 1 == firstBorrowRow && snakeCol == firstBorrowCol)
                            {
                                matrix[firstBorrowRow, firstBorrowCol] = '.';
                                snakeRow = secondBorrowRow;
                                snakeCol = secondBorrowCol;
                            }
                            else if (snakeRow - 1 == secondBorrowRow && snakeCol == secondBorrowCol)
                            {
                                matrix[secondBorrowRow, secondBorrowCol] = '.';
                                snakeRow = firstBorrowRow;
                                snakeCol = firstBorrowCol;
                            }
                            else snakeRow--;
                        }
                        else IsLost = true;

                        break;

                    case "down":
                        if (IsInRange(matrix, snakeRow + 1, snakeCol))
                        {
                            if (matrix[snakeRow + 1, snakeCol] == '*') { food++; snakeRow++; }

                            else if (snakeRow + 1 == firstBorrowRow && snakeCol == firstBorrowCol)
                            {
                                matrix[firstBorrowRow, firstBorrowCol] = '.';
                                snakeRow = secondBorrowRow;
                                snakeCol = secondBorrowCol;
                            }
                            else if (snakeRow + 1 == secondBorrowRow && snakeCol == secondBorrowCol)
                            {
                                matrix[secondBorrowRow, secondBorrowCol] = '.';
                                snakeRow = firstBorrowRow;
                                snakeCol = firstBorrowCol;
                            }
                            else snakeRow++;
                        }
                        else IsLost = true;

                        break;

                    case "left":
                        if (IsInRange(matrix, snakeRow, snakeCol - 1))
                        {
                            if (matrix[snakeRow, snakeCol - 1] == '*')
                            {
                                food++;
                                snakeCol--;
                            }

                            else if (snakeRow == firstBorrowRow && snakeCol - 1 == firstBorrowCol)
                            {
                                matrix[firstBorrowRow, firstBorrowCol] = '.';
                                snakeRow = secondBorrowRow;
                                snakeCol = secondBorrowCol;
                            }
                            else if (snakeRow == secondBorrowRow && snakeCol - 1 == secondBorrowCol)
                            {
                                matrix[secondBorrowRow, secondBorrowCol] = '.';
                                snakeRow = firstBorrowRow;
                                snakeCol = firstBorrowCol;
                            }
                            else snakeCol--;
                        }
                        else IsLost = true;

                        break;

                    case "right":
                        if (IsInRange(matrix, snakeRow, snakeCol + 1))
                        {
                            if (matrix[snakeRow, snakeCol + 1] == '*')
                            {
                                food++;
                                snakeCol++;
                            }

                            else if (snakeRow == firstBorrowRow && snakeCol + 1 == firstBorrowCol)
                            {
                                matrix[firstBorrowRow, firstBorrowCol] = '.';
                                snakeRow = secondBorrowRow;
                                snakeCol = secondBorrowCol;
                            }
                            else if (snakeRow == secondBorrowRow && snakeCol + 1 == secondBorrowCol)
                            {
                                matrix[secondBorrowRow, secondBorrowCol] = '.';
                                snakeRow = firstBorrowRow;
                                snakeCol = firstBorrowCol;
                            }
                            else snakeCol++;
                        }
                        else IsLost = true;

                        break;
                }

                if (IsLost) break;
                else if (food >= 10) { matrix[snakeRow, snakeCol] = 'S'; break; }
                else matrix[snakeRow, snakeCol] = 'S';

                cmd = Console.ReadLine();
            }

            if (IsLost) Console.WriteLine("Game over!");
            else if (food >= 10) Console.WriteLine("You won! You fed the snake.");

            Console.WriteLine($"Food eaten: {food}");

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
