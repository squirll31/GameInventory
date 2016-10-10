using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

namespace GameInventory.Areas.PRGE.Models
{
    [DataContract]
    public class PRGEWantedGameModel : PRGEBaseModel
    {
        public Dictionary<string, string> CoverImageMap { get; set; }

        [DataMember]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public PRGEWantedGameModel(int inId)
        {
            using (GameInventoryDBEntities db = new GameInventoryDBEntities())
            {
                var game = db.GetWantedGameById(inId).Single();
                Title = game.Title;
                Id = inId;
            }
        }

        public PRGEWantedGameModel()
        {
            Id = 0;
        }

        [DataContract]
        public class GameAccessory
        {
            [DataMember]
            public string AccessoryName;
        }

        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public ICollection<string> AltTitles { get; set; }
        [DataMember]
        public ICollection<GameAccessory> Accessories { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
        public int ReleaseYear { get { return ReleaseDate.Year; } }
        public int ReleaseDecade { get { return ReleaseDate.Year % 10; } }
        [DataMember]
        public ICollection<string> DLCs { get; set; }
        [DataMember]
        public ICollection<string> Genres { get; set; }
        [DataMember]
        public double MaxPrice { get; set; }
        [DataMember]
        public double IdealPrice { get; set; }
        [DataMember]
        public double ExpectedPrice { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public string DbgString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Title: {0}\n", Title);
            if ((AltTitles != null) && AltTitles.Any())
            {
                for (int x = 0; x < AltTitles.Count; x++)
                {
                    s.AppendFormat("AltTitle{0}:\n{1}\n", x + 1, AltTitles.ElementAt(x));
                }
            }
            if ((Accessories != null) && Accessories.Any())
            {
                for (int x = 0; x < Accessories.Count; x++)
                {
                    s.AppendFormat("Accessory{0}:\n{1}\n", x + 1, Accessories.ElementAt(x).AccessoryName);
                }
            }
            if ((DLCs != null) && DLCs.Any())
            {
                for (int x = 0; x < DLCs.Count; x++)
                {
                    s.AppendFormat("DLC{0}: {1}\n", x + 1, DLCs.ElementAt(x));
                }
            }
            if ((Genres != null) && Genres.Any())
            {
                for (int x = 0; x < Genres.Count; x++)
                {
                    s.AppendFormat("Genre{0}: {1}\n", x + 1, Genres.ElementAt(x));
                }
            }
            s.AppendFormat("Release Decade: {0}\n", ReleaseDecade);
            s.AppendFormat("Release Year: {0}\n", ReleaseYear);
            s.AppendFormat("Release Date: {0}\n", ReleaseDate);
            return s.ToString();
        }
    }
}