using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> items = new Stack<string>(Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList());

            CustomStack<string> myStack = new CustomStack<string>(items);

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Pop":
                        myStack.Pop();
                        break;

                    case "Push":
                        myStack.Push(command[1]);
                        break;
                }

                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray(); ;
            }

            myStack.Reverse();
            myStack.Print();
            myStack.Print();

        }
    }
}
