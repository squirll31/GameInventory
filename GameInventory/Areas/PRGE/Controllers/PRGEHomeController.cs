using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameInventory.Areas.PRGE.Controllers
{
    public class PRGEHomeController : Controller
    {
        // GET: PRGE/Index
        public ActionResult Index()
        {
            ViewBag.Title = "PRGE Tracker";
            return View();
        }
    }
}