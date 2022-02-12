using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            int index = int.Parse(Console.ReadLine());

            Person comparer = people[index - 1];

            int matches = 0;
            int unEquals = 0;

            foreach (Person person in people)
            {
                if (comparer.CompareTo(person) == 0)
                {
                    matches++;
                }
                else
                {
                    unEquals++;
                }
            }

            if (matches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {unEquals} {people.Count}");
            }
        }
    }
}
