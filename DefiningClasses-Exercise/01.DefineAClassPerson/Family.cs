using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DefiningClasses;

namespace _01.DefineAClassPerson
{
    class Family
    {
        List<Person> familyList;

        public List<Person> FamilyList { get => familyList; set => familyList = value; }

        public Family(List<Person> list)
        {
            familyList = list;
        }

        public Family()
        {
            FamilyList = new List<Person>();
        }

        public void AddMember(Person person)
        {
            familyList.Add(person);
        }

        public void GetOldestPersons()
        {
            foreach (var person in familyList.OrderBy(person => person.Name).Where(person => person.Age > 30))
            {

                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
