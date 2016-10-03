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
    public class PhysicalGameModel : GameModel, IComparable<GameModel>
    {
        public PhysicalGameModel()
            : base()
        {

        }

        public PhysicalGameModel(int id)
            : base(id)
        {
            //6044
            using (GameInventoryDBEntities db = new GameInventoryDBEntities())
            {
                var pg = db.GetPhysicalGameById(id).Single();
                this.Box = (pg.Box.HasValue) ? pg.Box.Value : false;
                this.Manual = (pg.Manual.HasValue) ? pg.Manual.HasValue : false;
                this.Version = pg.Version;
                this.Model = pg.Model;
            }
        }

        [DataContract]
        public class PhysicalGameInsert
        {
            [DataMember]
            public string InsertType;
        }

        [DataMember]
        public bool Box { get; set; }
        [DataMember]
        public bool Manual { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Version { get; set; }
        [DataMember]
        public ICollection<PhysicalGameInsert> Inserts { get; set; }
        [DataMember]
        public string SpecialEdition { get; set; }

        public int CompareTo(GameModel other)
        {
            if (other.Id == Id)
                return 0;
            else if (other.ReleaseDate < ReleaseDate)
                return 1;
            else
                return -1;
        }

        bool ComparePhysicalGame(PhysicalGameModel other)
        {
            bool ret = false;
            if (this == other)
            {
                ret = true;
            }
            return ret;
        }

        bool CompareDigitalGame(DigitalGameModel other)
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
            if (ot == typeof(DigitalGameModel)) {
                ret = CompareDigitalGame((DigitalGameModel)other);
            } else if (ot == typeof(PhysicalGameModel)) {
                ret = ComparePhysicalGame((PhysicalGameModel)other);
            } else if (ot == typeof(GameModel)) {
                base.Equals((GameModel)other);
            } else {
                ret = false;
            }
            return ret;
        }
    }
}