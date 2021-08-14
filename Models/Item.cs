using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

namespace PokemonMysteryDungeonNPCGenerator.Models
{
    public class Item
    {
        private static String[] ITEM_TYPES = { "Technical Machine", "Berry", "Medicine", "Other" };
        private enum ITEM_TYPES_ENUM {TM, BERRY, MEDICINE, OTHER };

        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<Pokemon> Holders { get; set; }

        public Item(int itemId, string name, string type, string description, List<Pokemon> holders)
        {
            ItemId = itemId;
            Name = name;
            Type = type;
            Description = description;
            Holders = holders;
        }

        public Item(int itemId, string name, int type, string description, List<Pokemon> holders)
        {
            ItemId = itemId;
            Name = name;
            Type = ITEM_TYPES[type];
            Description = description;
            Holders = holders;
        }


    }

}