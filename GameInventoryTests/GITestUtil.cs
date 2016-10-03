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

            List<GameModel> testGameList = new List<GameModel>();

            GameCompanyModel microsoft = new GameCompanyModel { GameCompanyName = "Microsoft" };
            GameCompanyModel capcom = new GameCompanyModel { GameCompanyName = "Capcom" };

            PlatformModel x360 = new PlatformModel
            {
                Developer = microsoft,
                Publisher = microsoft,
                PlatformName = "Xbox 360"
            };

            GameModel g1 = new PhysicalGameModel
            {
                Id = 1,
                Title = "Resident Evil 6",
                Box = false,
                Manual = false,
                Platform = x360,
                Publishers = new List<GameCompanyModel> { capcom },
                Developers = new List<GameCompanyModel> { capcom }
            };

            GameModel g2 = new PhysicalGameModel
            {
                Id = 2,
                Title = "Dead Rising 2",
                Box = false,
                Manual = false,
                Platform = x360,
                Publishers = new List<GameCompanyModel> { capcom },
                Developers = new List<GameCompanyModel> { capcom }
            };
            GameModel g3 = new DigitalGameModel
            {
                Id = 3,
                Title = "Mega Man 10",
                Platform = x360,
                Publishers = new List<GameCompanyModel> { capcom },
                Developers = new List<GameCompanyModel> { capcom },
                Service = "Xbox Live"
            };
            testGameList.Add(g1);
            testGameList.Add(g2);
            testGameList.Add(g3);

            GameCollectionGame gc = new GameCollectionGame
            {
                GamesInCollection = testGameList,
                Title = "Capcom Classics Collection",
                Publishers = new List<GameCompanyModel> { capcom },
                Platform = x360
            };
            return gc;
        }
    }
}
