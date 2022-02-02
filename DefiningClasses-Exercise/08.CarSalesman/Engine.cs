using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public string Model { get { return model; } set { model = value; } }

        public int Power { get { return power; } set { power = value; } }

        public int? Dicplacement { get => displacement; set => displacement = value; }

        public string Efficiency { get => efficiency; set => efficiency = value; }

        public Engine()
        {
            
        }

        public Engine(string model, int Power)
        {
            this.Model = model;
            this.Power = Power;
        }

        public Engine(string model, int Power, int displacement)
        {
            this.Model = model;
            this.Power = Power;
            this.displacement = displacement;
        }

        public Engine(string model, int Power, string efficiency)
        {
            this.Model = model;
            this.Power = Power;
            this.efficiency = efficiency;
        }

        public Engine(string model, int Power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = Power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }
}
