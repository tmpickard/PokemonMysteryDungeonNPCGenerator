using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Species { get; set; }
        public byte[] Image { get; set; }
        public int Level { get; set; }
        public bool Gender { get; set; }
        public string Nature { get; set; }
        public bool IsShiny { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int HPSpecies { get; set; }
        public int AttSpecies { get; set; }
        public int DefSpecies { get; set; }
        public int SPAttSpecies { get; set; }
        public int SPDefSpecies { get; set; }
        public int SpdSpecies { get; set; }
        public int HPTotal { get; set; }
        public int AttTotal { get; set; }
        public int DefTotal { get; set; }
        public int SPAttTotal { get; set; }
        public int SPDefTotal { get; set; }
        public int SpdTotal { get; set; }
        public int Overland { get; set; }
        public int Sky { get; set; }
        public int Swim { get; set; }
        public int Levitate { get; set; }
        public int Burrow { get; set; }
        public int HighJump { get; set; }
        public int LongJump { get; set; }
        public int Power { get; set; }
        public string Size { get; set; }
        public int Weight { get; set; }
        public string Acrobatics { get; set; }
        public string Athletics { get; set; }
        public string Charm { get; set; }
        public string Combat { get; set; }
        public string Command { get; set; }
        public string GenEd { get; set; } = "1d6+0";
        public string MedEd { get; set; } = "1d6+0";
        public string OccEd { get; set; } = "1d6+0";
        public string PokeEd { get; set; } = "1d6+0";
        public string TechEd { get; set; } = "1d6+0";
        public string Focus { get; set; }
        public string Guile { get; set; }
        public string Intimidate { get; set; }
        public string Intuition { get; set; }
        public string Perception { get; set; }
        public string Stealth { get; set; }
        public string Survival { get; set; }
        public List<Move> Moves { get; set; } //Moves learned at present
        public List<Move> Movelist { get; set; } //All possible moves
        public List<Habitat> Habitats { get; set; }
        public List<Capability> Capabilities { get; set; }
        public List<Ability> Abilities { get; set; }

        public Pokemon()
        {

        }


    }
}