using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameInventory.Models
{
    public class RecentGamesViewModel
    {
        public IEnumerable<GameInventory.RecentGame> RecentGameList;
    }
}