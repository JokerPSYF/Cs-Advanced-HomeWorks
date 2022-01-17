using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long[][] jaggedArr = new long[n][];
            for (long row = 0; row < n; row++)
            {
                jaggedArr[row] = new long[row + 1];
                for (long col = 0; col < row+1; col++)
                {
                    if (col != 0 && col != row)
                    {
                        jaggedArr[row][col] = jaggedArr[row - 1][col] + jaggedArr[row - 1][col - 1];
                    }
                    else
                    {
                        jaggedArr[row][col] = 1;
                    }
                }
            }

            for (long row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArr[row]));
            }
        }
    }
}
//The triangle may be constructed in the following manner: In row 0 (the topmost row),
//there is a unique nonzero entry 1. Each entry of each subsequent row is constructed
//by adding the number above and to the left with the number above and to the right,
//treating blank entries as 0. For example, the initial number in the first (or any other)
//row is 1(the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to
//produce the number 4 in the fourth row.
//    If you want more info about Pascal’s triangle here.
//    Print each row element separated with whitespace.
//The input number n will be 1 <= n <= 60
//    Think about the proper type for elements in the array
//    Don’t be scared to use more and more arrays