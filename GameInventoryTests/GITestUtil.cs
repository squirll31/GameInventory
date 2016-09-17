using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInventory.Models;

namespace GameInventoryTests
{
    public  class GITestUtil
    {
        public static GameCollectionGame MakeGameCollection()
        {
            List<Game> testGameList = new List<Game>();

            Game g1 = new PhysicalGame
            {
                Title = "Resident Evil 6",
                Box = false,
                Platform = new Platform { PlatformName = "Xbox 360" },
                Publishers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } },
                Developers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } }
            };
            Game g2 = new PhysicalGame
            {
                Title = "Dead Rising 2",
                Box = false,
                Platform = new Platform { PlatformName = "Xbox 360" },
                Publishers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } },
                Developers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } }
            };
            Game g3 = new DigitalGame
            {
                Title = "Mega Man 10",
                Platform = new Platform { PlatformName = "Xbox 360" },
                Publishers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } },
                Developers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } },
                Service = "Xbox Live"
            };
            testGameList.Add(g1);
            testGameList.Add(g2);
            testGameList.Add(g3);

            GameCollectionGame gc = new GameCollectionGame
            {
                GamesInCollection = testGameList,
                Title = "Capcom Classics Collection",
                Publishers = new List<GameCompany> { new GameCompany { GameCompanyName = "Capcom" } },
                Platform = new Platform { PlatformName = "Xbox 360" }
            };
            return gc;
        }
    }
}
