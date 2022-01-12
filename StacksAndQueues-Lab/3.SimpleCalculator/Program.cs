using System;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split());
            Stack<string> newStack = new Stack<string>(stack);
            int sum = 0;
            int s1;
            while (newStack.Count > 0)
            {
                string iterator = newStack.Pop();
                switch (iterator)
                {
                    case "-":
                        s1 = int.Parse(newStack.Pop());
                        sum -= s1;
                        break;
                    case "+":
                        s1 = int.Parse(newStack.Pop());
                        sum += s1;
                        break;
                    default:
                        sum = int.Parse(iterator);
                        break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
