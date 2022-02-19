using System;
using System.Linq;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int money = 0;

            int myRow = default;

            int myCol = default;

            int firstPillarRow = -1;

            int firstPillarCol = -1;

            int secondPillarRow = -1;

            int secondPillarCol = -1;

            bool IsLost = false;

            for (int rows = 0; rows < size; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                if (input.Contains('S'))
                {
                    myRow = rows;
                }

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (input[cols] == 'S') myCol = cols;

                    else if (input[cols] == 'O')
                    {
                        if (firstPillarRow == -1)
                        {
                            firstPillarRow = rows;
                            firstPillarCol = cols;
                        }
                        else
                        {
                            secondPillarRow = rows;
                            secondPillarCol = cols;
                        }
                    }
                }
            }


            while (money < 50)
            {
                string cmd = Console.ReadLine();

                matrix[myRow, myCol] = '-';

                switch (cmd)
                {
                    case "up":
                        if (IsInRange(matrix, myRow - 1, myCol))
                        {
                            if (char.IsDigit(matrix[myRow - 1, myCol]))
                            {
                                money += int.Parse(matrix[myRow - 1, myCol].ToString());
                                myRow--;
                            }

                            else if (myRow - 1 == firstPillarRow && myCol == firstPillarCol)
                            {
                                matrix[firstPillarRow, firstPillarCol] = '-';
                                myRow = secondPillarRow;
                                myCol = secondPillarCol;
                            }
                            else if (myRow - 1 == secondPillarRow && myCol == secondPillarCol)
                            {
                                matrix[secondPillarRow, secondPillarCol] = '-';
                                myRow = firstPillarRow;
                                myCol = firstPillarCol;
                            }
                            else myRow--;
                        }
                        else IsLost = true;

                        break;

                    case "down":
                        if (IsInRange(matrix, myRow + 1, myCol))
                        {
                            if (char.IsDigit(matrix[myRow + 1, myCol])) { money += int.Parse(matrix[myRow + 1, myCol].ToString()); ; myRow++; }

                            else if (myRow + 1 == firstPillarRow && myCol == firstPillarCol)
                            {
                                matrix[firstPillarRow, firstPillarCol] = '-';
                                myRow = secondPillarRow;
                                myCol = secondPillarCol;
                            }
                            else if (myRow + 1 == secondPillarRow && myCol == secondPillarCol)
                            {
                                matrix[secondPillarRow, secondPillarCol] = '.';
                                myRow = firstPillarRow;
                                myCol = firstPillarCol;
                            }
                            else myRow++;
                        }
                        else IsLost = true;

                        break;

                    case "left":
                        if (IsInRange(matrix, myRow, myCol - 1))
                        {
                            if (char.IsDigit(matrix[myRow, myCol - 1]))
                            {
                                money += int.Parse(matrix[myRow, myCol - 1].ToString());
                                myCol--;
                            }

                            else if (myRow == firstPillarRow && myCol - 1 == firstPillarCol)
                            {
                                matrix[firstPillarRow, firstPillarCol] = '-';
                                myRow = secondPillarRow;
                                myCol = secondPillarCol;
                            }
                            else if (myRow == secondPillarRow && myCol - 1 == secondPillarCol)
                            {
                                matrix[secondPillarRow, secondPillarCol] = '-';
                                myRow = firstPillarRow;
                                myCol = firstPillarCol;
                            }
                            else myCol--;
                        }
                        else IsLost = true;

                        break;

                    case "right":
                        if (IsInRange(matrix, myRow, myCol + 1))
                        {
                            if (char.IsDigit(matrix[myRow, myCol + 1]))
                            {
                                money += int.Parse(matrix[myRow, myCol + 1].ToString());
                                myCol++;
                            }

                            else if (myRow == firstPillarRow && myCol + 1 == firstPillarCol)
                            {
                                matrix[firstPillarRow, firstPillarCol] = '-';
                                myRow = secondPillarRow;
                                myCol = secondPillarCol;
                            }
                            else if (myRow == secondPillarRow && myCol + 1 == secondPillarCol)
                            {
                                matrix[secondPillarRow, secondPillarCol] = '-';
                                myRow = firstPillarRow;
                                myCol = firstPillarCol;
                            }
                            else myCol++;
                        }
                        else IsLost = true;

                        break;
                }
                if (IsLost) break;
                else matrix[myRow, myCol] = 'S';

            }

            if (IsLost) Console.WriteLine("Bad news, you are out of the bakery.");
            else if (money >= 10) Console.WriteLine("Good news! You succeeded in collecting enough money!");

            Console.WriteLine($"Money: {money}");

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

