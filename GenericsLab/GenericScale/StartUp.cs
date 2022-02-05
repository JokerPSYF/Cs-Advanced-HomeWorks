using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> myName = new EqualityScale<string>("Todor", "Vasilev");

            Console.WriteLine(myName.AreEqual());
        }
    }
}
