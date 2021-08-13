using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Habitat
    {
        public int HabitatId { get; set; }
        public string Name { get; set; }
        public List<Pokemon> LocalPokemon { get; set; }

        public Habitat(int habitatId, string name, List<Pokemon> localPokemon)
        {
            HabitatId = habitatId;
            Name = name;
            LocalPokemon = localPokemon;
        }
    }
}