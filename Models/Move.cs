using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Move
    {
        public int MoveId { get; set; } //Primary Key
        public string MoveName { get; set; } //This is the name of the move in question.  EX: Tackle, Take Down, Blizzard
        public string Type { get; set; } //Type of the move in question.  EX:  Dark, Psychic, Water, etc.
        public string Category { get; set; } //Physical, Special, status
        public int DamageBase { get; set; } //Integer dictating how powerful a move is.  Charactersheets on roll20 will handle exact dice conversion
        public string Frequency { get; set; } //At-will, EOT, Scene x2, etc
        public int Accuracy { get; set; } //Minimum roll plus evasion bonus of target.
        public string Range { get; set; } //Self explanitory.  Other facts can be noted here.
        public string Effects { get; set; } //Any special gimmicks will be noted here.
        public List<Pokemon> PokemonID { get; set; }  //This list will track which Pokemon objects are able to use a certain move.
    }
}