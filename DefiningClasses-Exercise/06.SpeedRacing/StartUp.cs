using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int totalCars = int.Parse(Console.ReadLine());

            var allCars = new Dictionary<string, Car>();

            for (int i = 0; i < totalCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumption);
                allCars.Add(model, newCar);
            }

            string[] driveInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (driveInput[0] != "End")
            {
                if (driveInput[0] == "Drive")
                {
                    Car driveCar = allCars[driveInput[1]];
                    driveCar.Drive(double.Parse(driveInput[2]));
                }

                driveInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var car in allCars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
