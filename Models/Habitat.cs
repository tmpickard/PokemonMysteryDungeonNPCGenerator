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
    }
}