using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<int, Tire[]> tires = new Dictionary<int, Tire[]>();

            int tireCounter = 0;

            while (input != "No more tires")
            {
                string[] tiresInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] newTires = new Tire[4]
                {
                    new Tire(int.Parse(tiresInput[0]), double.Parse(tiresInput[1])),
                    new Tire(int.Parse(tiresInput[2]), double.Parse(tiresInput[3])),
                    new Tire(int.Parse(tiresInput[4]), double.Parse(tiresInput[5])),
                    new Tire(int.Parse(tiresInput[6]), double.Parse(tiresInput[7])),
                };

                tires.Add(tireCounter, newTires);

                tireCounter++;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            Dictionary<int, Engine> engines = new Dictionary<int, Engine>();

            int engineCounter = 0;

            while (input != "Engines done")
            {
                string[] engineInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                engines.Add(engineCounter, new Engine(int.Parse(engineInput[0]),
                    double.Parse(engineInput[1])));

                engineCounter++;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<Car> cars = new List<Car>();

            while (input != "Show special")
            {
                string[] carsInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = carsInput[0];

                string model = carsInput[1];

                int year = int.Parse(carsInput[2]);

                double fuelQuantity = double.Parse(carsInput[3]);

                double fuelConsumption = double.Parse(carsInput[4]);

                int engineIndex = int.Parse(carsInput[5]);

                int tireIndex = int.Parse(carsInput[6]);

                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);

                cars.Add(newCar);

                input = Console.ReadLine();
            }

            List<Car> specialsCars = new List<Car>();

            foreach (Car car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330
                                     && car.Tires.Sum(x => x.Pressure) >= 9.0
                                     && car.Tires.Sum(x => x.Pressure) <= 10.0)
                {
                    car.Drive(20);

                    specialsCars.Add(car);
                }
            }

            specialsCars.ForEach(car => Console.Write(car.WhoAmI()));
        }
    }
}