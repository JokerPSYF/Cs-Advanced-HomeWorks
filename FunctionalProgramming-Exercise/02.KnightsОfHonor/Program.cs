using System;

namespace _02.KnightsОfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gentlemens = Console.ReadLine().Split();

            Action<string[]> giveThemHonor = gentlemens =>
            {
                foreach (var gentlemen in gentlemens)
                {
                    Console.WriteLine("Sir " + gentlemen);
                }
            };

            giveThemHonor(gentlemens);
        }
    }
}
//Create a program that reads a collection of names as strings from the console,
//appends "Sir" in front of every name, and prints it back on the console. Use Action<T>.