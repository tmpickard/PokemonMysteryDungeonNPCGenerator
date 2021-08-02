using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class LearnableMoves
    {
        public int LearnableMoveID { get; set; } //Primary Key
        public int PokemonId { get; set; } //Foreign Key for Pokemon
        public int MoveId { get; set; } //Foreign Key for specific Move
        public string LearnMethod { get; set; } //States whether a pokemon learns a move by leveling up, TM, tutoring, egg move, etc.
        public int LearnLevel { get; set; } = 1; //Defaults as 1 unless otherwise stated.
    }
}