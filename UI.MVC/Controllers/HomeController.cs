using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        //Post protokolü ile çağırılan aksiyon modeli.
        [HttpPost]
        public ActionResult Contact(ContactFormViewModel model)
        {
            //Contact sayfasından gelen bilgi burada işlenir.
            return View(model);
        }
    }
}