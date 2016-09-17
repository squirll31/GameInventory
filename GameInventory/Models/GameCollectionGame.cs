using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameInventory.Models
{
    public class GameCollectionGame : Game, 
                                      IEnumerable<Game>, 
                                      ICollection<Game>
    {
        public GameCollectionGame()
        {
            GamesInCollection = new List<Game>();
        }

        public string CollectionName { get; set; }
        public ICollection<Game> GamesInCollection { get; set; }

        #region ICollection_Impl
        public int Count { get { return GamesInCollection.Count; } }
        public bool IsReadOnly { get { return GamesInCollection.IsReadOnly; } }
        public void Add(Game item) { GamesInCollection.Add(item); }
        public void Clear() { GamesInCollection.Clear(); } 
        public bool Contains(Game item) { return GamesInCollection.Contains(item); }
        public void CopyTo(Game[] array, int arrayIndex) { GamesInCollection.CopyTo(array, arrayIndex); }
        public bool Remove(Game item) { return GamesInCollection.Remove(item); }
        #endregion

        #region IEnumerator_Impl
        public IEnumerator<Game> GetEnumerator() { return GamesInCollection.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return GamesInCollection.GetEnumerator(); } }
        #endregion
}