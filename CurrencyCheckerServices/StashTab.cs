using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyCheckerServices
{
    public class StashTabSet
    {
        public String Next_change_id { get; set; }
        public IEnumerable<StashTab> Stashes { get; set; }
    }

    public class StashTab
    {
        public String Id { get; set; }
        [JsonProperty(PropertyName = "public")]
        public bool PublicTab { get; set; }
        public String AccountName { get; set; }
        public String LastCharacterName { get; set; }
        public String Stash { get; set; }
        public String StashType { get; set; }
        public String League { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }

    public class Item
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int ilvl { get; set; }
        public String icon { get; set; }
        public String league { get; set; }
        public String id { get; set; }
        public String name { get; set; }
        public String typeLine { get; set; }
        public bool identified { get; set; }
        public String note { get; set; }
        //public List<Property> properties { get; set; }
        //public List<Requirement> requirements { get; set; }
        //public List<Mod> explicitMods { get; set; }
        //public List<String> flavourText{ get; set; }
        public int frameType { get; set; }
        //public ItemCategory category{ get; set; }
  
        //public String inventoryId { get; set; }
        //public List<SocketedItem> socketedItems { get; set; }



    }

    public class Socket
    {
        public int group { get; set; }
        public string attr { get; set; }
        public string sColour { get; set; }
    }

    public class Property
    {
        public string name { get; set; }
        public IEnumerable<IEnumerable<object>> values { get; set; }
        public int displayMode { get; set; }
        public int type { get; set; }
    }

    public class AdditionalProperty
    {
        public string name { get; set; }
        public IEnumerable<IEnumerable<object>> values { get; set; }
        public int displayMode { get; set; }
        public int progress { get; set; }
    }

    public class Requirement
    {
        public string name { get; set; }
        public IEnumerable<IEnumerable<object>> values { get; set; }
        public int displayMode { get; set; }
    }

    public class NextLevelRequirement
    {
        public string name { get; set; }
        public IEnumerable<IEnumerable<object>> values { get; set; }
        public int displayMode { get; set; }
    }

    public class Currency : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Albino Rhoa Feather",
            "Alteration Shard",
            "Ancient Orb",
            "Ancient Shard",
            "Alchemy Shard",
            "Annulment Shard",
            "Apprentice Cartographer's Seal",
            "Apprentice Cartographer's Sextant",
            "Armourer's Scrap",
            "Binding Shard",
            "Blacksmith's Whetstone",
            "Blessed Orb",
            "Cartographer's Chisel",
            "Chaos Orb",
            "Chaos Shard",
            "Chromatic Orb",
            "Divine Orb",
            "Engineer's Orb",
            "Engineer's Shard",
            "Eternal Orb",
            "Exalted Orb",
            "Exalted Shard",
            "Gemcutter's Prism",
            "Glassblower's Bauble",
            "Harbinger's Orb",
            "Harbinger's Shard",
            "Horizon Shard",
            "Jeweller's Orb",
            "Journeyman Cartographer's Seal",
            "Journeyman Cartographer's Sextant",
            "Master Cartographer's Seal",
            "Master Cartographer's Sextant",
            "Mirror Shard",
            "Mirror of Kalandra",
            "Orb of Alchemy",
            "Orb of Alteration",
            "Orb of Annulment",
            "Orb of Augmentation",
            "Orb of Binding",
            "Orb of Chance",
            "Orb of Fusing",
            "Orb of Horizons",
            "Orb of Regret",
            "Orb of Scouring",
            "Orb of Transmutation",
            "Perandus Coin",
            "Portal Scroll",
            "Regal Orb",
            "Regal Shard",
            "Transmutation Shard",
            "Scroll of Wisdom",
            "Scroll Fragment",
            "Silver Coin",
            "Stacked Deck",
            "Unshaping Orb",
            "Vaal Orb",

            "Splinter of Chayula",
            "Splinter of Esh",
            "Splinter of Tul",
            "Splinter of Uul-Netol",
            "Splinter of Xoph",

        };

        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int stackSize { get; set; }
        public bool maxStackSize { get; set; }
        public string inventoryId { get; set; }
        public ItemCategory category { get; set; }

        public class ItemCategory
        {
                public List<object> currency { get; set; }
        }
    }
}
