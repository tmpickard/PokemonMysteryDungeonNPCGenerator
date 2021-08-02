﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; } //Primary Key
        public string Species { get; set; } //Name Of Pokemon
        public byte[] Image { get; set; } //Bit string to hold image
        public int Level { get; set; } //Dictates level of pokemon.  May remove as level isn't stored in db and may be better stored on front end?  Need to find out how.
        public bool Gender { get; set; } //Denotes Male or Female Gender
        public string Nature { get; set; }  //TODO: Create Enum field for nature?
        public bool IsShiny { get; set; } //Cutting this as the image stored will not be shiny
        public string Type1 { get; set; } //First/primary type of the pokemon
        public string Type2 { get; set; } //Can be null.  Secondary type of pokemon if applicable.
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
        public string Size { get; set; }  //TODO: Create Enum field for Size.  Consider restructuring 
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
        public List<Habitat> Habitats { get; set; } //Lists all habitats
        public List<Capability> Capabilities { get; set; }  //Lists all Tabletop RP specific capabilities, 
        public List<Ability> Abilities { get; set; }

        public Pokemon()
        {

        }


    }
}