using System;
using System.Linq;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            const char P1Symbol = '<';
            const char P2Symbol = '>';
            const char Mine = '#';

            int p1Ships = 0;
            int p2Ships = 0;

            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int[] cmd = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == P1Symbol)
                    {
                        p1Ships++;
                    }
                    else if (input[j] == P2Symbol)
                    {
                        p2Ships++;
                    }
                }
            }

            int allShips = p1Ships + p2Ships;

            for (int i = 0; i < cmd.Length - 1; i += 2)
            {
                int cmdRow = cmd[i];
                int cmdCol = cmd[i + 1];
                if (!IsInRange(matrix, cmdRow, cmdCol)) continue;

                if (matrix[cmdRow, cmdCol ] == Mine)
                {
                    matrix[cmdCol, cmdCol] = 'X';
                    //Up Left
                    if (IsInRange(matrix, cmdRow - 1, cmdCol - 1))
                    {
                        Checker(ref matrix, cmdRow - 1, cmdCol - 1 , ref p1Ships, ref p2Ships);
                    }
                    //Up
                    if (IsInRange(matrix, cmdRow - 1, cmdCol))
                    {
                        Checker(ref matrix, cmdRow - 1, cmdCol, ref p1Ships, ref p2Ships);
                    }
                    //Up Right
                    if (IsInRange(matrix, cmdRow - 1, cmdCol + 1))
                    {
                        Checker(ref matrix, cmdRow - 1, cmdCol + 1, ref p1Ships, ref p2Ships);
                    }
                    //Right
                    if (IsInRange(matrix, cmdRow, cmdCol + 1))
                    {
                        Checker(ref matrix, cmdRow, cmdCol + 1, ref p1Ships, ref p2Ships);
                    }
                    //Down Right
                    if (IsInRange(matrix, cmdRow + 1, cmdCol + 1))
                    {
                        Checker(ref matrix, cmdRow + 1, cmdCol + 1, ref p1Ships, ref p2Ships);
                    }
                    //Down
                    if (IsInRange(matrix, cmdRow + 1, cmdCol))
                    {
                        Checker(ref matrix, cmdRow + 1, cmdCol, ref p1Ships, ref p2Ships);
                    }
                    //Down Left
                    if (IsInRange(matrix, cmdRow + 1, cmdCol - 1))
                    {
                        Checker(ref matrix, cmdRow + 1, cmdCol - 1, ref p1Ships, ref p2Ships);
                    }
                    //Left
                    if (IsInRange(matrix, cmdRow, cmdCol - 1))
                    {
                        Checker(ref matrix, cmdRow, cmdCol - 1, ref p1Ships, ref p2Ships);
                    }
                }
                else
                {
                    Checker(ref matrix, cmdRow, cmdCol, ref p1Ships, ref p2Ships);
                }

                if (p1Ships == 0 || p2Ships == 0)
                {
                    break;
                }
            }

            if (p1Ships == 0)
            {
                Console.WriteLine($"Player Two has won the game! {allShips - p2Ships} ships have been sunk in the battle.");
            }
            else if (p2Ships == 0)
            {
                Console.WriteLine($"Player One has won the game! {allShips - p1Ships} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {p1Ships} ships left. Player Two has {p2Ships} ships left.");
            }
        }

        static bool IsInRange(char[,] matrix, int row, int col)
            => row >= 0 && row < matrix.GetLength(0)
                        && col < matrix.GetLength(1) && col >= 0;

        static void Checker(ref char[,] matrix, int row, int col, ref int p1Ships, ref int p2Ships)
        {
            switch (matrix[row, col])
            {
                case '<':
                    matrix[row, col] = 'X';
                    p1Ships--;
                    break;

                case '>':
                    matrix[row, col] = 'X';
                    p2Ships--;
                    break;
            }
        }
    }
}
