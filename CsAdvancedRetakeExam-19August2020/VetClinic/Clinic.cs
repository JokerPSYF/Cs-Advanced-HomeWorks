using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public List<Pet> data;

        public List<Pet> Pets { get => data; set => data = value; }

        public int Capacity { get; set; }

        public int Count => Pets.Count;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            Pets = new List<Pet>();
        }

        public void Add(Pet pet)
        {
            if (Pets.Count < Capacity)
            {
                Pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet racer = Pets.FirstOrDefault(x => x.Name == name);
            if (racer != null)
            {
                Pets.Remove(racer);
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner) => Pets.FirstOrDefault(x => x.Name == name);

        public Pet GetOldestPet() => Pets.OrderByDescending(x => x.Age).First();

        public string GetStatistics()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("The clinic has the following patients:");

            foreach (Pet pet in Pets)
            {
                builder.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}