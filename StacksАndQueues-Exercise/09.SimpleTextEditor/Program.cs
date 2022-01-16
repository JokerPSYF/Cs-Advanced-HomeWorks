using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            stack.Push(sb.ToString());
            int count;
            if (n < 1 && n > 105)
            {
                n = 0;
            }

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int cmd = int.Parse(input[0]);
                switch (cmd)
                {
                    case 1:
                        string someStr = input[1];
                        sb.Append(someStr);
                        stack.Push(sb.ToString());
                        break;
                    case 2:
                        count = int.Parse(input[1]);
                        sb.Remove(sb.Length - count, count);
                        stack.Push(sb.ToString());

                        break;
                    case 3:
                        count = int.Parse(input[1]);
                        Console.WriteLine(sb[count - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        if (stack.Any())
                        {
                            sb.Clear();
                            sb.Append(stack.Peek());
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}