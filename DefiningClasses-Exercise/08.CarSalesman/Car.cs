using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public Car()
        {
            
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
        {
            Model = model;
            Engine = engine;
            Color = color;
        }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");

            if (!Engine.Dicplacement.HasValue)
            {
                sb.AppendLine("    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {Engine.Dicplacement}");
            }
            
            if (Engine.Efficiency == null)
            {
                sb.AppendLine("    Efficiency: n/a");
            }
            else
            {
                sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }

            if (!Weight.HasValue)
            {
                sb.AppendLine("  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {Weight}");
            }

            if (Color == null)
            {
                sb.AppendLine("  Color: n/a");
            }
            else
            {
                sb.AppendLine($"  Color: {Color}");
            }

            return sb.ToString();
        }
    }
}


//"{CarModel}:
//{ EngineModel}:
//Power: { EnginePower}
//Displacement: { EngineDisplacement}
//Efficiency: { EngineEfficiency}
//Weight: { CarWeight}
//Color: { CarColor}
//"

