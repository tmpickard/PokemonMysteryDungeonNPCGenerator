using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Capability
    {
        public int CapabilityId { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public List<Pokemon> Pokemon { get; set; }
    }
}