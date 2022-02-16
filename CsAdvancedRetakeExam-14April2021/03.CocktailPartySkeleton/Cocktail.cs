using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public List<Ingredient> Ingredients { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => Ingredients.Sum(x => x.Alcohol);

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;

            Capacity = capacity;

            MaxAlcoholLevel = maxAlcoholLevel;

            Ingredients = new List<Ingredient>();
        }

        public void Add(Ingredient ingredient)
        {
            if ((!Ingredients.Contains(ingredient))
                && Capacity > Ingredients.Count
                && Ingredients.Sum(x => x.Alcohol) + ingredient.Alcohol < MaxAlcoholLevel)
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            Ingredient removeThat = Ingredients.FirstOrDefault(x => x.Name == name);

            if (removeThat == null)
            {
                return false;
            }

            Ingredients.Remove(removeThat);
            return true;
        }

        public Ingredient FindIngredient(string name) => Ingredients.FirstOrDefault(x => x.Name == name);

        public Ingredient GetMostAlcoholicIngredient() => Ingredients.OrderByDescending(x => x.Alcohol).First();

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            builder.AppendLine(string.Join(Environment.NewLine, Ingredients));

            return builder.ToString().TrimEnd();
        }

    }
}