using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Any questions? Send us a message!";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Blog page.";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}