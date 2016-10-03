using System;
using System.Linq;
using System.Collections.Generic;
using GameInventory.Models;
using GameInventoryTests;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using GameInventory;

namespace GameInventoryTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void SerializeTest()
        {
            var gc = GITestUtil.MakeCapcomGameCollection();
            foreach (var g in gc)
            {
                string seralized = JsonConvert.SerializeObject(g, Formatting.Indented);
                Console.WriteLine("Serialized object:\n{0}", seralized);
            }
        }

        [TestMethod]
        public void SeralizeGameCollectionGameTest()
        {
            var gc = GITestUtil.MakeCapcomGameCollection();
            string seralized = JsonConvert.SerializeObject(gc, Formatting.Indented);
            Console.WriteLine("Serialized object:\n{0}", seralized);
        }

        [TestMethod]
        public void DescTest()
        {

            GameCollectionGame gc = GITestUtil.MakeCapcomGameCollection();
            string seralized = JsonConvert.SerializeObject(gc, Formatting.Indented);
            GameCollectionGame gcDes = JsonConvert.DeserializeObject<GameCollectionGame>(seralized);
            for (int x = 0; x < gc.Count; x++)
            {
                Console.WriteLine("{0} : {1} - {2}", gc.ElementAt(x).GetType(),
                                                 gcDes.ElementAt(x).GetType(),
                                                 gc);
            }
        }

        
        [TestMethod]
        public void SerializeDeserializeGameTest()
        {

            GameCollectionGame gc = GITestUtil.MakeCapcomGameCollection();
            string seralized = JsonConvert.SerializeObject(gc, Formatting.Indented);
            Console.WriteLine("Serialized object:\n{0}", seralized);
            GameCollectionGame gcDes = JsonConvert.DeserializeObject<GameCollectionGame>(seralized);
            string deseralized = JsonConvert.SerializeObject(gcDes, Formatting.Indented);
            Console.WriteLine("Deserialized object:\n{0}", deseralized);
            //Console.WriteLine(gc);
            //Console.WriteLine(gcDes);

            //var s = gcDes.Where(e => e.GetType() == typeof(PhysicalGame)).ToList();
            foreach (var g in gcDes) { Console.WriteLine(g.GetType()); }

            for (int x = 0; x < gc.Count; x++)
            {
                // A physical Game
                GameModel g1 = (GameModel)gc.ElementAt(x);
                // a Game
                GameModel g2 = gcDes.ElementAt(x);
                GameModel g1a = g1;
                GameModel g2a = g2;


                Assert.AreEqual(g1, g1);
                Assert.AreEqual(g2, g2);
                Assert.AreEqual(g1, g1a);
                Assert.AreEqual(g2, g2a);

                if (g1 == g2)
                {
                    Console.WriteLine("equals");
                } else
                {
                    Console.WriteLine("notequals");
                    string gc1s = JsonConvert.SerializeObject(g1, Formatting.Indented);
                    //Console.WriteLine("Before:\n{0}", gc1s);
                    string gc2s = JsonConvert.SerializeObject(g2, Formatting.Indented);
                    //Console.WriteLine("After:\n{0}", gc2s);
                }
                Assert.AreEqual(g1, g2);
                //Assert.IsTrue(g1 == g2);
            }
        }

        [TestMethod]
        public void GetPlatform()
        {
            int targetId = 3;
            PlatformModel p = new PlatformModel(targetId);
            Console.WriteLine("Got platform id: {0}: {1}", p.Id, p.PlatformName);
            Console.WriteLine(p);
        }

        [TestMethod]
        public void GetGame()
        {
            int targetId = 5011;
            GameModel g = new GameModel(targetId);
            Console.WriteLine(g);
            Console.WriteLine(g.Platform);
            Console.WriteLine(g.Title);
            Console.WriteLine(g.Id);
        }

        [TestMethod]
        public void GetPhysicalGame()
        {
            int targetId = 6044;
            PhysicalGameModel g = new PhysicalGameModel(targetId);
            Console.WriteLine(g);
            Console.WriteLine(g.Box);
            Console.WriteLine(g.Manual);
            Console.WriteLine(g.Platform);
            Console.WriteLine(g.Title);
            Console.WriteLine(g.Id);
            Console.WriteLine(g.Version);
            Console.WriteLine(g.Model);
        }

        [TestMethod]
        public void TestGameCollectionDisplay()
        {
            var gc = GITestUtil.MakeCapcomGameCollection();
            int digitalGames = gc.OfType<DigitalGameModel>().Count();
            int physicalGames = gc.OfType<PhysicalGameModel>().Count();
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
            var gc = GITestUtil.MakeCapcomGameCollection();
            int digitalGames = gc.OfType<DigitalGameModel>().Count();
            int physicalGames = gc.OfType<PhysicalGameModel>().Count();
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
