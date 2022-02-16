using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        //Name: string
        //Alcohol: int
        //Quantity: int

        public string Name { get; set; }

        public int Alcohol { get; set; }

        public int Quantity { get; set; }

        public Ingredient(string name, int alcohol, int quantity)
        {
            Name = name;

            Alcohol = alcohol;

            Quantity = quantity;
        }

        public override string ToString() => $"Ingredient: { Name }\nQuantity: { Quantity}\nAlcohol: { Alcohol}";

    }
}