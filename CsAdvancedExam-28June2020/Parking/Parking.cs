using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        //Type: string
        //Capacity: int
        public List<Car> Data;

        public List<Car> Cars { get => Data; set => Data = value; }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => Cars.Count;

        public Parking(string type, int capacity)
        {
            Cars = new List<Car>();
            Type = type;
            Capacity = capacity;
        }

        public void Add(Car car)
        {
            if (Cars.Count < Capacity)
            {
                Cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = Cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (car != null)
            {
                Cars.Remove(car);
                return true;
            }

            return false;
        }

        public Car GetLatestCar()
        {
            if (Cars.Count > 0)
            {
                return  Cars.OrderByDescending(x => x.Year).First();
            }

            return null;
        }

        public Car GetCar(string manufacturer, string model)
            => Cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);

        public string GetStatistics()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"The cars are parked in {Type}:");

            builder.AppendLine(string.Join(Environment.NewLine, Cars));

            return builder.ToString().TrimEnd();
        }
    }
}