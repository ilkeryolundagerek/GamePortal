using Core.Abstracts.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace UI.MVC.Controllers
{
    public class NewsController : Controller
    {


        public NewsController()
        {

        }

        // GET: News
        public ActionResult Index()
        {
            return View();
        }
    }
}