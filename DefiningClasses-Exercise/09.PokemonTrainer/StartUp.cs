using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DefiningClasses.PokemonTrainer;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            //  List<Pokemon> pokemons = new List<Pokemon>();


            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);

                Pokemon newPokemon = new Pokemon(pokemonName, element, health);

                if (trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName].AddPokemon(newPokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName, newPokemon);
                    trainers.Add(trainerName, newTrainer);
                }


                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string givenElement = Console.ReadLine();

            while (givenElement != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    bool winBadge = false;
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == givenElement)
                        {
                            winBadge = true;
                        }
                    }

                    if (winBadge) trainer.Badges++;
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
                givenElement = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(tr => tr.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }

        }
    }
}

