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

        public Ability(int abilityId, string name, int abilityType, string frequency, string effect1, string target, string keywords, string effect2, List<Pokemon> pokemon)
        {
            AbilityId = abilityId;
            Name = name;
            AbilityType = abilityType;
            Frequency = frequency;
            Effect1 = effect1;
            Target = target;
            Keywords = keywords;
            Effect2 = effect2;
            Pokemon = pokemon;
        }
    }
}