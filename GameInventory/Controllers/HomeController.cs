using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Web.Mvc;
using GameInventory.Models;

namespace GameInventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GameInventoryDBEntities db = new GameInventoryDBEntities();
            RecentGamesViewModel rgv = new RecentGamesViewModel();
            rgv.RecentGameList = new List<GameInventory.RecentGame>(db.RecentGames.ToList());
            return View(rgv);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}