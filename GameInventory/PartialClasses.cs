using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameInventory
{
    [MetadataType(typeof(GameInventory.Models.GameMetadata))]
    public partial class Game
    {
    }

    [MetadataType(typeof(GameInventory.Models.GameCompanyMetadata))]
    public partial class GameCompany
    {

    }

    [MetadataType(typeof(GameInventory.Models.GameOwnerMetadata))]
    public partial class GameOwner
    {
    }

    [MetadataType(typeof(GameInventory.Models.GameRegionMetadata))]
    public partial class GameRegion
    {
    }

    [MetadataType(typeof(GameInventory.Models.PlatformMetadata))]
    public partial class Platform
    {
    }
}