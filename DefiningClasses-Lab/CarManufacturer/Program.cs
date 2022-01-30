using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
//Create a class named Car.The class should have private fields for:
//    make: string
//    model: string
//    year: int
//    The class should also have public properties for:
//    Make: string
//    Model: string
//    Year: int