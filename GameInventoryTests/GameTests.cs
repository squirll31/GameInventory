using System;
using System.Linq;
using System.Collections.Generic;
using GameInventory.Models;
using GameInventoryTests;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameInventoryTests
{
    [TestClass]
    public class GameTests
    {


        [TestMethod]
        public void SerializeTest()
        {
            var gc = GITestUtil.MakeGameCollection();
            foreach (var g in gc)
            {
                string seralized = JsonConvert.SerializeObject(g, Formatting.Indented);
                Console.WriteLine("Seralized object:\n{0}", seralized);
            }
        }


        [TestMethod]
        public void TestGameCollectionDisplay()
        {
            var gc = GITestUtil.MakeGameCollection();
            int digitalGames = gc.OfType<DigitalGame>().Count();
            int physicalGames = gc.OfType<PhysicalGame>().Count();
            Console.WriteLine("{0} Digital {1} and {2} Physical {3} in \"{4}\".",
                digitalGames,
                (digitalGames < 2) ? "Game" : "Games",
                physicalGames,
                (physicalGames < 2) ? "Game" : "Games",
                gc.Title);

            for (int x = 0; x < gc.Count; x++)
            {
                Console.WriteLine("=== Game #{0}:\n{1}===\n", x+1, gc.ElementAt(x));
            }
        }

        [TestMethod]
        public void TestGameCollectionDisplayIter()
        {
            var gc = GITestUtil.MakeGameCollection();
            int digitalGames = gc.OfType<DigitalGame>().Count();
            int physicalGames = gc.OfType<PhysicalGame>().Count();
            Console.WriteLine("{0} Digital {1} and {2} Physical {3} in \"{4}\".",
                digitalGames,
                (digitalGames < 2) ? "Game" : "Games",
                physicalGames,
                (physicalGames < 2) ? "Game" : "Games",
                gc.Title);
            int x = 0;
            foreach (var game in gc)
            {
                Console.WriteLine("=== Game #{0}:\n{1}===\n", x+1, game);
                x++;
            }
        }
    }
}
