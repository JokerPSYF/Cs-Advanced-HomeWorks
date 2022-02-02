using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DefiningClasses;


namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                int speed = int.Parse(info[1]);
                double power = double.Parse(info[2]);
                double wigth = double.Parse(info[3]);
                string type = info[4];
                List<Tire> tires = new List<Tire>();

                for (int j = 5; j <= 12; j += 2)
                {
                    int age = int.Parse(info[j + 1]);
                    double pressure = double.Parse(info[j]);
                    Tire tire = new Tire(age, pressure);
                    tires.Add(tire);
                }

                Cargo cargo = new Cargo(type, wigth);
                Engine engine = new Engine(speed, power);
                Car newCar = new Car(model, engine, cargo, tires.ToArray());
                allCars.Add(newCar);
            }

            string typeCar = Console.ReadLine();

            if (typeCar == "fragile")
            {
                foreach (var car in allCars.Where(car => car.Cargo.Type == typeCar))
                {
                    bool isLessThan1 = false;
                    foreach (Tire tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            isLessThan1 = true;
                        }

                    }

                    if (isLessThan1)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (typeCar == "flammable")
            {
                foreach (var car in allCars.Where(car => car.Cargo.Type == typeCar)
                    .Where(engine => engine.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
