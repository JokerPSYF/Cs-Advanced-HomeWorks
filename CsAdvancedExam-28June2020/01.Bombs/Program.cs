using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bombs:
            //    Datura Bombs: 40
            //    Cherry Bombs: 60
            //    Smoke Decoy Bombs: 120

            int daturaBombs = 0;

            int cherryBombs = 0;

            int smokeDecoyBombs = 0;

            bool IsBombsDone = false;

            Queue<int> effects = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> casings = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (effects.Count > 0 && casings.Count > 0)
            {
                int effect = effects.Peek();
                int casing = casings.Peek();
                int bomb = effect + casing;

                switch (bomb)
                {
                    case 40:
                        daturaBombs++;
                        effects.Dequeue();
                        casings.Pop();
                        break;
                    case 60:
                        cherryBombs++;
                        effects.Dequeue();
                        casings.Pop();
                        break;
                    case 120:
                        smokeDecoyBombs++;
                        effects.Dequeue();
                        casings.Pop();
                        break;
                    default:
                        casings.Push(casings.Pop() - 5);
                        break;
                }

                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    IsBombsDone = true;
                    break;
                }
            }

            if (IsBombsDone) Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            else Console.WriteLine("You don't have enough materials to fill the bomb pouch.");

            if (effects.Count == 0) Console.WriteLine("Bomb Effects: empty");
            else Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");

            if (casings.Count == 0) Console.WriteLine("Bomb Casings: empty");
            else Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
