using System;
using System.Linq;
namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int count = 1;
            int removedKnights = 0;
            while (true)
            {
                int bestAttacks = 0;
                int bestRow = 0;
                int bestCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {

                        if (matrix[row, col] == '0')
                        {
                            continue;
                        }

                        int attacked = 0;

                        if (IsRange(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                        {
                            attacked++;
                        }

                        if (IsRange(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                        {
                            attacked++;
                        }

                        if (attacked > bestAttacks)
                        {
                            bestAttacks = attacked;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }
                if (bestAttacks > 0)
                {
                    removedKnights++;
                    matrix[bestRow, bestCol] = '0';
                    count++;
                    
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    return;
                }
            }
        }
        private static bool IsRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1)
                            && col >= 0;
        }
    }
}
//Chess is the oldest game, but it is still popular these days. For this task, we will use only one chess piece – the Knight. 
//    The knight moves to the nearest square but not on the same row, column, or diagonal.
// (This can be thought of as moving two squares horizontally, then one square vertically,
// or moving one square horizontally then two squares vertically— i.e. in an "L" pattern.) 
//The knight game is played on a board with dimensions N x N and a lot of chess knights 0 <= K <= N2. 
//    You will receive a board with K for knights and '0' for empty cells.
// Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight. 
//    Input
//    On the first line, you will receive the N side of the board
//On the next N lines, you will receive strings with Ks and 0s.
//    Output
//    Print a single integer with the minimum number of knights that needs to be removed
//Constraints
//    Size of the board will be 0 < N < 30
//    Time limit: 0.3 sec.Memory limit: 16 MB.