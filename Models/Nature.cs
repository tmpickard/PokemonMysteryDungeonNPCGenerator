using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Nature
    {
        public int NatureId { get; set; }
        public string Name { get; set; }
        public string StatIncrease { get; set; }
        public string StatDecrease { get; set; }

        public Nature(int natureId, string name, string statIncrease, string statDecrease)
        {
            NatureId = natureId;
            Name = name;
            StatIncrease = statIncrease;
            StatDecrease = statDecrease;
        }
    }
}