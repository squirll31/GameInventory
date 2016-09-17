using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GameInventory.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PhysicalGame : Game
    {
        public class PhysicalGameInsert
        {
            public string InsertType;
        }

        [JsonProperty]
        public bool Box { get; set; }
        [JsonProperty]
        public bool Manual { get; set; }
        [JsonProperty]
        public string Model { get; set; }
        [JsonProperty]
        public string Version { get; set; }
        [JsonProperty]
        public string Condition { get; set; }
        [JsonProperty]
        public ICollection<PhysicalGameInsert> Inserts { get; set; }
        [JsonProperty]
        public string SpecialEdition { get; set; }
    }
}