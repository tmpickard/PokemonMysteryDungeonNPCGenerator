using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Move
    {
        public int MoveId { get; set; }
        public string MoveName { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public int DamageBase { get; set; }
        public string Frequency { get; set; }
        public int Accuracy { get; set; }
        public string Range { get; set; }
        public string Effects { get; set; }
        public List<Pokemon> PokemonID {get; set; }
    }
}