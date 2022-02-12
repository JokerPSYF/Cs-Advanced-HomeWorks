using System;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;

            Age = age;

            Town = town;
        }

        public int CompareTo(Person other)
            => Name.CompareTo(other.Name) == 0 ? 
                Age.CompareTo(other.Age) == 0 ?
                Town.CompareTo(other.Town) :
                Age.CompareTo(other.Age) :
                Name.CompareTo(other.Name);
    }
}