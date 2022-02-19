namespace BakeryOpenning
{
    public class Employee
    {
        //Name: string
        //Age: int
        //Country: string

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Employee(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public override string ToString() => $"Employee: {Name}, {Age} ({Country})";
      
    }
}