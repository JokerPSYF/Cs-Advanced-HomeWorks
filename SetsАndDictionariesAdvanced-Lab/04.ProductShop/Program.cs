using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> catalogue =
                new Dictionary<string, Dictionary<string, double>>();
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Revision")
            {
                string market = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!catalogue.ContainsKey(market))
                {
                    catalogue.Add(market, new Dictionary<string, double>());
                    catalogue[market].Add(product, price);
                }
                else if (catalogue[market].ContainsKey(product))
                {
                    catalogue[market][product] = price;
                }
                else
                {
                    catalogue[market].Add(product, price);
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var pair in catalogue.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Key + "->");
                foreach (var product in pair.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
//Create a program that prints information about food shops in Sofia and the products they store.
//Until the "Revision" command is received, you will be receiving input in the format:
//"{shop}, {product}, {price}".Keep in mind that if you receive a shop you already have received,
//you must collect its product information.
//    Your output must be ordered by shop name and must be in the format:
//"{shop}->
//Product: { product}, Price: { price}
//"
//Note: The price should not be rounded or formatted.