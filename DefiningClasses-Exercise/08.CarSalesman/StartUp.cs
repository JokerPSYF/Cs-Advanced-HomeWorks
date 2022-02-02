using System;
using System.Collections.Generic;
using DefiningClasses;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = info[0];
                int power = int.Parse(info[1]);
                Engine newEngine = new Engine(model, power);

                if (info.Length == 4)
                {
                    int displacement = int.Parse(info[2]);
                    string effieciency = info[3];

                    newEngine = new Engine(model, power, displacement, effieciency);
                }
                else if (info.Length == 3)
                {
                    bool isInt = int.TryParse(info[2], out int result);

                    if (isInt)
                    {
                        newEngine = new Engine(model, power, result);
                    }
                    else
                    {
                        newEngine = new Engine(model, power, info[2]);
                    }
                }
                engines.Add(model, newEngine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = info[0];
                Engine engine = engines[info[1]];
                Car newCar = new Car(model, engine);

                if (info.Length == 4)
                {
                    int weight = int.Parse(info[2]);
                    string color = info[3];

                    newCar = new Car(model, engine, weight, color);
                }
                else if (info.Length == 3)
                {
                    bool isInt = int.TryParse(info[2], out int result);

                    if (isInt)
                    {
                        newCar = new Car(model, engine, result);
                    }
                    else
                    {
                        newCar = new Car(model, engine, info[2]);
                    }
                }
                cars.Add(newCar);
            }
            foreach (Car car in cars)
            {
                Console.Write(car);
            }
        }
    }
}
