using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(intArr);
            string[] cmd = Console.ReadLine().ToLower().Split();
            int sum = 0;
            while (cmd[0] != "end")
            {
                if (cmd[0] == "add" )
                {
                    stack.Push(int.Parse(cmd[1]));
                    stack.Push(int.Parse(cmd[2]));
                }
                else if (cmd[0] == "remove")
                {
                    if (stack.Count >= int.Parse(cmd[1]))
                    {
                        for (int i = 0; i < int.Parse(cmd[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                cmd = Console.ReadLine().ToLower().Split();
            }
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
