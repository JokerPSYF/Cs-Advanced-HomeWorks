using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            Stack<int> plates = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            plates = ReverseStack(plates);

            Stack<int> orcs = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                int[] newWarriors = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                foreach (int warrior in newWarriors)
                {
                    orcs.Push(warrior);
                }

                if (i % 3 == 0)
                {
                    plates = ReverseStack(plates);

                    plates.Push(int.Parse(Console.ReadLine()));

                    plates = ReverseStack(plates);
                }

                while (orcs.Count > 0 && plates.Count > 0)
                {
                    int plate = plates.Pop();
                    int orc = orcs.Pop();
                    if (plate > orc)
                    {
                        plates.Push(plate - orc);
                    }
                    else if (orc > plate)
                    {
                        orcs.Push(orc - plate);
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Any())
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }

        static Stack<int> ReverseStack(Stack<int> stack)
        {
            Stack<int> newStack = new Stack<int>();

            while (stack.Count != 0)
            {
                newStack.Push(stack.Pop());
            }

            return newStack;
        }
    }
}