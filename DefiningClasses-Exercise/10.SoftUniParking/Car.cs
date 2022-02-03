using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistrationNumber { get; set; }

        public Car(string make, string model, int hp, string registNum)
        {
            Make = make;
            Model = model;
            HorsePower = hp;
            RegistrationNumber = registNum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {HorsePower}");
            sb.Append($"RegistrationNumber: {RegistrationNumber}");
            return sb.ToString();
        }
    }
}
