using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < loops; i++)
            {
                Queue<int> input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
                switch (input.Dequeue())
                {
                    case 1:
                        stack.Push(input.Dequeue());
                        break;

                    case 2:
                        if (stack.Count > 0) stack.Pop();
                        break;

                    case 3:
                        if (stack.Count > 0) Console.WriteLine(stack.Max());
                        break;

                    case 4:
                        if (stack.Count > 0) Console.WriteLine(stack.Min());
                        break;
                }
            }

            if (stack.Count > 0) Console.WriteLine(string.Join(", ", stack));
        }
    }
}
