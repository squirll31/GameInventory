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
    public class DigitalGameModel : GameModel,
                                    IComparable<GameModel> {
        //[JsonProperty]
        [DataMember]
        public string Service;
        public int CompareTo(GameModel other)
        {
            if (other.Id == Id)
                return 0;
            else if (other.ReleaseDate < ReleaseDate)
                return 1;
            else
                return -1;
        }


        bool CompareDigitalGame(DigitalGameModel other)
        {
            bool ret = false;
            if (this == other)
            {
                ret = true;
            }
            return ret;
        }

        bool ComparePhysicalGame(PhysicalGameModel other)
        {
            bool ret = true;
            foreach (var i in typeof(GameModel).GetProperties())
            {
                if (i.GetValue(this) != i.GetValue(other))
                {
                    ret = false;
                }
            }
            return ret;
        }

        public override bool Equals(object other)
        {
            bool ret = true;
            // the type of other
            Type ot = other.GetType();
            if (ot == typeof(PhysicalGameModel))
            {
                ret = ComparePhysicalGame((PhysicalGameModel)other);
            }
            else if (ot == typeof(DigitalGameModel))
            {
                ret = CompareDigitalGame((DigitalGameModel)other);
            }
            else if (ot == typeof(GameModel))
            {
                base.Equals((GameModel)other);
            }
            else {
                ret = false;
            }
            return ret;
        }

    }
}