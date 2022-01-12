using System;
using System.Collections.Generic;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string strArr = Console.ReadLine();
            Stack<char> stack = new Stack<char>(strArr);
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
