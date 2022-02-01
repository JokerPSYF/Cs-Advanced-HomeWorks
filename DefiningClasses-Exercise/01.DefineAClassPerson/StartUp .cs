using System;
using _01.DefineAClassPerson;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int personsCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < personsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }

            family.GetOldestPersons();

        }
    }
}
