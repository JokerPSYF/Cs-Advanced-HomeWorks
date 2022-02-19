using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        public List<Employee> data;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Employee> Employees { get => data; set => data = value; }
        public int Count => Employees.Count;

        public Bakery(string name, int capacity)
        {
            Employees = new List<Employee>();
            Name = name;
            Capacity = capacity;
        }

        public void Add(Employee employee)
        {
            if (Employees.Count < Capacity)
            {
                Employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee car = Employees.FirstOrDefault(x => x.Name == name);
            if (car != null)
            {
                Employees.Remove(car);
                return true;
            }

            return false;
        }

        public Employee GetOldestEmployee() => Employees.OrderByDescending(x => x.Age).First();

        public Employee GetEmployee(string name) => Employees.FirstOrDefault(x => x.Name == name);

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Employees working at Bakery {Name}:");

            builder.AppendLine(string.Join(Environment.NewLine, Employees));

            return builder.ToString().TrimEnd();
        }

    }
}