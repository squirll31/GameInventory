using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace GameInventory.Models
{
    //[JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class PhysicalGame : Game
    {
        public class PhysicalGameInsert
        {
            public string InsertType;
        }

        //[JsonProperty]
[DataMember]
        public bool Box { get; set; }
        //[JsonProperty]
[DataMember]
        public bool Manual { get; set; }
        //[JsonProperty]
[DataMember]
        public string Model { get; set; }
        //[JsonProperty]
[DataMember]
        public string Version { get; set; }
        //[JsonProperty]
[DataMember]
        public string Condition { get; set; }
        //[JsonProperty]
[DataMember]
        public ICollection<PhysicalGameInsert> Inserts { get; set; }
        //[JsonProperty]
[DataMember]
        public string SpecialEdition { get; set; }
    }
}