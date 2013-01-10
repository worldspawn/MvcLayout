using System.Web.Mvc;

namespace MvcApp.Handlers.MyArea
{
    public class MyAreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MyArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MyArea_default",
                "MyArea/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new [] { "MvcApp.Handlers.MyArea.*" }
            );
        }
    }
}
