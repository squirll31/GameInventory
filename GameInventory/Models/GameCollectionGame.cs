using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace GameInventory.Models
{
    //[JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class GameCollectionGame : GameModel, 
                                      IEnumerable<GameModel>, 
                                      ICollection<GameModel>,
                                      IComparable<GameModel>
    {
        public GameCollectionGame()
        {
            GamesInCollection = new List<GameModel>();
            PhysicalGames = new List<PhysicalGameModel>();
            DigitalGames = new List<DigitalGameModel>();
        }
        public int CompareTo(GameModel other)
        {
            if (other.Id == Id)
                return 0;
            else if (other.ReleaseDate < ReleaseDate)
                return 1;
            else
                return -1;
        }

        public ICollection<GameModel> GamesInCollection { get; set; }

        //[JsonProperty]
        [DataMember]
        public ICollection<PhysicalGameModel> PhysicalGames { get; set; }

        //[JsonProperty]
        [DataMember]
        public ICollection<DigitalGameModel> DigitalGames{ get; set; }

        #region ICollection_Impl
        public int Count { get { return GamesInCollection.Count; } }
        public bool IsReadOnly { get { return GamesInCollection.IsReadOnly; } }
        public void Add(GameModel item) { GamesInCollection.Add(item); }
        public void Clear() { GamesInCollection.Clear(); } 
        public bool Contains(GameModel item) { return GamesInCollection.Contains(item); }
        public void CopyTo(GameModel[] array, int arrayIndex) { GamesInCollection.CopyTo(array, arrayIndex); }
        public bool Remove(GameModel item) { return GamesInCollection.Remove(item); }
        #endregion

        #region IEnumerator_Impl
        public IEnumerator<GameModel> GetEnumerator() { return GamesInCollection.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return GamesInCollection.GetEnumerator(); } }
        #endregion
}