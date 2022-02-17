using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public List<Racer> Data;

        public List<Racer> Racers { get => Data; set => Data = value; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => Racers.Count;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Racers = new List<Racer>();
        }

        public void Add(Racer racer)
        {
            if (Racers.Count < Capacity)
            {
                Racers.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = Racers.FirstOrDefault(x => x.Name == name);
            if (racer != null)
            {
                Racers.Remove(racer);
                return true;
            }

            return false;
        }

        public Racer GetOldestRacer() => Racers.OrderByDescending(x => x.Age).First();

        public Racer GetRacer(string name) => Racers.FirstOrDefault(x => x.Name == name);

        public Racer GetFastestRacer() => Racers.OrderByDescending(x => x.Car.Speed).First();

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Racers participating at {Name}:");

            builder.AppendLine(string.Join(Environment.NewLine, Racers));

            return builder.ToString().TrimEnd();
        }
    }
}