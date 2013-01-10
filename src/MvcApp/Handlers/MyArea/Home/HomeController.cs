using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Handlers.MyArea.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}