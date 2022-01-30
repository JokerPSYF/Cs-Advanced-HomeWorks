using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //FIELDS

        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        private Engine engine;

        private Tire[] tires;

        //PROPERTIES

        public string Make { get { return make; } set { this.make = value; } }

        public string Model { get { return model; } set { model = value; } }

        public int Year { get { return year; } set { year = value; } }

        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }

        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

        public Engine Engine { get { return engine; } set { engine = value; } }

        public Tire[] Tires { get { return tires; } set { tires = value; } }

        //CONSTRUCTOR

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelConsumption = 10;
            this.FuelQuantity = 200;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Model = model;
            this.Year = year;
            this.Make = make;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
        }

        public Car(string make, string model, int year,
            double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        //METHODS

        public void Drive(double distance)
        {
            if (FuelQuantity - (FuelConsumption * distance / 100) >= 0)
            {
                fuelQuantity -= distance * fuelConsumption / 100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder youAre = new StringBuilder();

            youAre.AppendLine($"Make: {this.Make}");

            youAre.AppendLine($"Model: { this.Model}");

            youAre.AppendLine($"Year: { this.Year}");

            youAre.AppendLine($"HorsePowers: {this.Engine.HorsePower}");

            youAre.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            return youAre.ToString();
        }
    }
}
