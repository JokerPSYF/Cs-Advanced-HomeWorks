using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private int speed;
        private double power;

        public int Speed { get { return speed; } set { speed = value; } }

        public double Power { get { return power; } set { power = value; } }


        public Engine(int speed, double Power)
        {
            this.Speed = speed;
            this.Power = Power;
        }
    }
}
