using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace GameInventory.Models
{
    ////[JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    [KnownType(typeof(PhysicalGame))]
    [KnownType(typeof(DigitalGame))]
    public class Game
    {
        //[JsonObject(MemberSerialization.OptIn)]
        [DataContract]
        public class GameAccessory
        {
            ////[JsonProperty]
[DataMember]
            public string AccessoryName;
        }

        ////[JsonProperty]
[DataMember]
        public int Id { get; set; }

        ////[JsonProperty]
[DataMember]
        public string Title { get; set; }

        ////[JsonProperty]
[DataMember]
        public ICollection<GameCompany> Publishers { get; set; }

        ////[JsonProperty]
[DataMember]
        public ICollection<GameCompany> Developers { get; set; }

        ////[JsonProperty]
[DataMember]
        public ICollection<string> AltTitles { get; set; }

        ////[JsonProperty]
[DataMember]
        public Platform Platform { get; set; }

        ////[JsonProperty]
[DataMember]
        public ICollection<GameAccessory> Accessories { get; set; }

        ////[JsonProperty]
[DataMember]
        public DateTime ReleaseDate { get; set; }

        public int ReleaseYear { get { return ReleaseDate.Year; } }

        public int ReleaseDecade { get { return ReleaseDate.Year % 10; } }

        ////[JsonProperty]
[DataMember]
        public ICollection<string> DLCs { get; set; }

        ////[JsonProperty]
[DataMember]
        public ICollection<string> Genres { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public string DbgString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Title: {0}\n", Title);
            if (!string.IsNullOrEmpty(Platform.PlatformName)) {
                s.AppendFormat("Platform:\n{0}", Platform);
            }
            if ((Publishers != null) && Publishers.Any())
            {
                for (int x = 0; x < Publishers.Count; x++)
                {
                    s.AppendFormat("Publisher{0}:\n{1}\n", x+1, Publishers.ElementAt(x));
                }
            }
            if ((Developers != null) && Developers.Any())
            {
                for (int x = 0; x < Developers.Count; x++)
                {
                    s.AppendFormat("Developer{0}:\n{1}\n", x+1, Developers.ElementAt(x));
                }
            }
            if ((AltTitles != null) && AltTitles.Any())
            {
                for (int x = 0; x < AltTitles.Count; x++)
                {
                    s.AppendFormat("AltTitle{0}:\n{1}\n", x+1, AltTitles.ElementAt(x));
                }
            }
            if ((Accessories != null) && Accessories.Any())
            {
                for (int x = 0; x < Accessories.Count; x++)
                {
                    s.AppendFormat("Accessory{0}:\n{1}\n", x+1, Accessories.ElementAt(x).AccessoryName);
                }
            }
            if ((DLCs != null) && DLCs.Any())
            {
                for (int x = 0; x < DLCs.Count; x++)
                {
                    s.AppendFormat("DLC{0}: {1}\n", x+1, DLCs.ElementAt(x));
                }
            }
            if ((Genres != null) && Genres.Any())
            {
                for (int x = 0; x < Genres.Count; x++)
                {
                    s.AppendFormat("Genre{0}: {1}\n", x+1, Genres.ElementAt(x));
                }
            }
            s.AppendFormat("Release Decade: {0}\n", ReleaseDecade);
            s.AppendFormat("Release Year: {0}\n", ReleaseYear);
            s.AppendFormat("Release Date: {0}\n", ReleaseDate);
            return s.ToString();
        }
    }
}