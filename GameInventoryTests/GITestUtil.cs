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
        public static GameCollectionGame MakeCapcomGameCollection()
        {

            List<Game> testGameList = new List<Game>();

            GameCompany microsoft = new GameCompany { GameCompanyName = "Microsoft" };
            GameCompany capcom = new GameCompany { GameCompanyName = "Capcom" };

            Platform x360 = new Platform
            {
                Developer = microsoft,
                Publisher = microsoft,
                PlatformName = "Xbox 360"
            };

            Game g1 = new PhysicalGame
            {
                Title = "Resident Evil 6",
                Box = false,
                Manual = false,
                Platform = x360,
                Publishers = new List<GameCompany> { capcom },
                Developers = new List<GameCompany> { capcom }
            };

            Game g2 = new PhysicalGame
            {
                Title = "Dead Rising 2",
                Box = false,
                Manual = false,
                Platform = x360,
                Publishers = new List<GameCompany> { capcom },
                Developers = new List<GameCompany> { capcom }
            };
            Game g3 = new DigitalGame
            {
                Title = "Mega Man 10",
                Platform = x360,
                Publishers = new List<GameCompany> { capcom },
                Developers = new List<GameCompany> { capcom },
                Service = "Xbox Live"
            };
            testGameList.Add(g1);
            testGameList.Add(g2);
            testGameList.Add(g3);

            GameCollectionGame gc = new GameCollectionGame
            {
                GamesInCollection = testGameList,
                Title = "Capcom Classics Collection",
                Publishers = new List<GameCompany> { capcom },
                Platform = x360
            };
            return gc;
        }
    }
}
