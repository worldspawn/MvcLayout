using System.Web.Mvc;

namespace MvcApp.Handlers.Default.Test
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Blah()
        {
            return View();
        }
    }
}