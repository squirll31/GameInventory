﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Runtime.Serialization;
//using Newtonsoft.Json;

namespace GameInventory.Models
{

    //[JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class GameCompanyModel
    {
        //[JsonProperty]
        //[DataMember]
        [DataMember]
        public int GameCompanyId { get; set; }
        //[JsonProperty]
        [DataMember]
        public string GameCompanyName { get; set; }
        public ICollection<GameModel> GameCompanyGames { get; set; }
        public GameCompanyModel()
        {
            GameCompanyId = 0;
            GameCompanyName = "";
        }
        public override string ToString()
        {
            return GameCompanyName;
        }

        public string DbgString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat(GameCompanyName);
            return s.ToString();
        }
    }
}