using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }

        public int Badges{ get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer() { }

        public Trainer(string name, Pokemon pokemon)
        {
            Name = name;

            Pokemons = new List<Pokemon>();

            Pokemons.Add(pokemon);
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void RemovePokemon(Pokemon pokemon)
        {
            Pokemons.Remove(pokemon);
        }
    }
}