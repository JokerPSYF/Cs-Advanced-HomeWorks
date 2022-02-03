using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SoftUniParking
{
    public class Parking
    {
        private static List<Car> cars;
        private int capacity;

        public static List<Car> Cars { get => cars; set => cars = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Count => Cars.Count;

        public Parking() { }

        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }

        public string AddCar(Car car)
        {
            foreach (var automobile in Cars)
            {
                if (automobile.RegistrationNumber == car.RegistrationNumber)
                {
                    return "Car with that registration number, already exists!";
                }
            }

            if (Cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registNumber)
        {
            foreach (var automobile in Cars)
            {
                if (automobile.RegistrationNumber == registNumber)
                {
                    string success = $"Successfully removed {automobile.RegistrationNumber}";
                    Cars.Remove(automobile);
                    return success;
                }
            }

            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registrationNum)
        {

            //Car thatCar = Cars.FirstOrDefault(car => car.RegistrationNumber == registrationNum);

            //return thatCar;
            foreach (Car car in Cars)
            {
                if (car.RegistrationNumber == registrationNum)
                {
                    return car;
                }
            }

            return null;
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string removeThatCar in RegistrationNumbers)
            {
                Cars.RemoveAll(x => x.RegistrationNumber == removeThatCar);
            }
        }
    }
}