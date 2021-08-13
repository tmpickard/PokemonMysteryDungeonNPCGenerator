using System;
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
        public string Gender { get; set; } //Denotes Male or Female Gender or lack thereof.  
        public string Type1 { get; set; } //First/primary type of the pokemon
        public string Type2 { get; set; } //Can be null.  Secondary type of pokemon if applicable.
        public int HP { get; set; } //Denotes Hit Point calculations
        public int Attack { get; set; } //Denotes physical attack power
        public int Defense { get; set; } //Denotes resistance to physical attacks
        public int SPAttack { get; set; } //Denotes energy based/distance attack power
        public int SPDefense { get; set; } //Denotes resistance to energy based/distance attacks
        public int Speed { get; set; } //Determines initiative, speed, etc
        public int Overland { get; set; } //Determines movement on ground
        public int Sky { get; set; } //Determines movement in the sky
        public int Swim { get; set; }  //Determines movement in and underwater
        public int Levitate { get; set; }  //Determines movement in the air without the use of wings
        public int Burrow { get; set; }  //Determines movement while underground
        public int HighJump { get; set; }  //Determines verticle jumping distance
        public int LongJump { get; set; } //Determines jumping distance for clearing chasms
        public int Power { get; set; } //Determines lifting/pushing power for large objects and obstacles
        
        public int Size { get; set; }  //TODO: Create Enum field for Size.  Consider restructuring 
        public int Weight { get; set; } //Stat for determining weight
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
        public List<Move> Movelist { get; set; } //All possible moves
        public List<Habitat> Habitats { get; set; } //Lists all habitats
        public List<Capability> Capabilities { get; set; }  //Lists all Tabletop RP specific capabilities, 
        public List<Ability> Abilities { get; set; }  //Lists all abilities possessed by a pokemon
        public List<Item> Items { get; set; }

        public Pokemon(int pokemonId, string species, byte[] image, int level, bool gender, string nature, string type1, string type2, int hPSpecies, int attSpecies, int defSpecies, int sPAttSpecies, int sPDefSpecies, int spdSpecies, int overland, int sky, int swim, int levitate, int burrow, int highJump, int longJump, int power, string size, int weight, string acrobatics, string athletics, string charm, string combat, string command, string genEd, string medEd, string occEd, string pokeEd, string techEd, string focus, string guile, string intimidate, string intuition, string perception, string stealth, string survival, List<Move> moves, List<Move> movelist, List<Habitat> habitats, List<Capability> capabilities, List<Ability> abilities) 
        {
            PokemonId = pokemonId;
            Species = species;
            Image = image;
            Level = level;
            Gender = gender;
            Nature = nature;
            Type1 = type1;
            Type2 = type2;
            HPSpecies = hPSpecies;
            AttSpecies = attSpecies;
            DefSpecies = defSpecies;
            SPAttSpecies = sPAttSpecies;
            SPDefSpecies = sPDefSpecies;
            SpdSpecies = spdSpecies;
            Overland = overland;
            Sky = sky;
            Swim = swim;
            Levitate = levitate;
            Burrow = burrow;
            HighJump = highJump;
            LongJump = longJump;
            Power = power;
            Size = size;
            Weight = weight;
            Acrobatics = acrobatics;
            Athletics = athletics;
            Charm = charm;
            Combat = combat;
            Command = command;
            GenEd = genEd;
            MedEd = medEd;
            OccEd = occEd;
            PokeEd = pokeEd;
            TechEd = techEd;
            Focus = focus;
            Guile = guile;
            Intimidate = intimidate;
            Intuition = intuition;
            Perception = perception;
            Stealth = stealth;
            Survival = survival;
            Moves = moves;
            Movelist = movelist;
            Habitats = habitats;
            Capabilities = capabilities;
            Abilities = abilities;
        }

        public Pokemon()
        {

        }


    }
}