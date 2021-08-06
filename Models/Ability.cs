using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Ability
    {

        public enum ABILITY_TYPE { REGULAR, HIDDEN, ADVANCED }
        public int AbilityId { get; set; }
        public string Name { get; set; }
        public int AbilityType { get; set; } //TODO: Create Enum for determining if ability is hidden, or advanced.
        public string Frequency { get; set; }
        public string Effect1 { get; set; }
        public string Target { get; set; }
        public string Keywords { get; set; }
        public string Effect2 { get; set; }
        
        public List<Pokemon> Pokemon { get; set; }
    }
}