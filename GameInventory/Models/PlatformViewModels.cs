using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameInventory.Models
{ 
    public class GamesForPlatformViewModel
    {
        public IEnumerable<Games_SelectAllByPlatform_Result> GamesList;
    }
}