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
    public class DigitalGame : Game
    {
        //[JsonProperty]
[DataMember]
        public string Service;
    }
}