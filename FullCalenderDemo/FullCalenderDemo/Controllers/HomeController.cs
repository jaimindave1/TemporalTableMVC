using FullCalenderDemo.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FullCalenderDemo.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetEvents()
        {
            var eventList = new List<Events>()
            {
                new Events()
                {
                    start = System.DateTime.Now,
                    end = System.DateTime.Now,
                    title = "Lecture 1"
                },
                new Events()
                {
                    start = System.DateTime.Now,
                    end = System.DateTime.Now,
                    title = "Lecture 2"
                },
            };

            return Json(eventList, JsonRequestBehavior.AllowGet);
        }
    }
}