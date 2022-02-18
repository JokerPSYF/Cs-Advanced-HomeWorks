using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack lilies
            //queue roses
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int removedFlowers = 0;

            int wreaths = 0;


            while (lilies.Count != 0 && roses.Count != 0)
            {
                int rose = roses.Peek();
                int lily = lilies.Peek();

                if (rose + lily > 15) lilies.Push(lilies.Pop() - 2);
                else if (rose + lily < 15)
                {
                    removedFlowers += rose + lily;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else
                {
                    wreaths++; roses.Dequeue();
                    lilies.Pop();
                }
            }

            if (removedFlowers >= 15) wreaths += removedFlowers / 15;

            if (wreaths >= 5) Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            else Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
        }
    }
}
