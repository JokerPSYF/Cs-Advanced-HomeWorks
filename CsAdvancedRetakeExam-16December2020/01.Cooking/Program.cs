using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bread 25
            //Cake    50
            //Pastry  75
            //Fruit Pie   100

            int Bread = 0;

            int Cake = 0;

            int Pastry = 0;

            int fruitPie = 0;

            bool IsBakeDone = false;

            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (liquids .Count > 0 && ingredients.Count > 0)
            {
                int liquid = liquids .Peek();
                int ingridient = ingredients.Peek();
                int food = liquid + ingridient;

                switch (food)
                {
                    case 25:
                        Bread++;
                        liquids .Dequeue();
                        ingredients.Pop();
                        break;

                    case 50:
                        Cake++;
                        liquids .Dequeue();
                        ingredients.Pop();
                        break;

                    case 75:
                        Pastry++;
                        liquids .Dequeue();
                        ingredients.Pop();
                        break;

                    case 100:
                        fruitPie++;
                        liquids.Dequeue();
                        ingredients.Pop();
                        break;

                    default:
                        liquids.Dequeue();
                        ingredients.Push(ingredients.Pop() + 3);
                        break;
                }
            }

            if (Bread > 0 && Cake > 0 && Pastry > 0 && fruitPie > 0 )
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");

            if (liquids .Count == 0) Console.WriteLine("Liquids left: none");
            else Console.WriteLine($"Liquids left: {string.Join(", ", liquids )}");

            if (ingredients.Count == 0) Console.WriteLine("Ingredients left: none");
            else Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");

            Console.WriteLine($"Bread: {Bread}");
            Console.WriteLine($"Cake: {Cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {Pastry}");
        }
    }
}