using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesis = new Stack<char>();
            foreach (char item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    parenthesis.Push(item);
                }

                else if (parenthesis.Count > 0)
                {
                    if (item == ')' && parenthesis.Peek() == '(')
                    {
                        parenthesis.Pop();
                    }
                    else if (item == '}' && parenthesis.Peek() == '{')
                    {

                        parenthesis.Pop();
                    }
                    else if (item == ']' && parenthesis.Peek() == '[')
                    {

                        parenthesis.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            if (parenthesis.Count == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
