using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class LearnableMoves
    {
        public int LearnableMoveID { get; set; }
        public int PokemonId { get; set; }
        public int MoveId { get; set; }
        public string LearnMethod { get; set; }
        public int LearnLevel { get; set; }
    }
}