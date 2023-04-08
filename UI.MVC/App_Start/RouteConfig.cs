using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //Özel Rotalar:
            routes.MapRoute("about page", "about-us", new { controller = "home", action = "about" });

            routes.MapRoute("contact page", "contact-us", new { controller = "home", action = "contact" });


            //Genel (Generic) Rota: Üstte yer alan özel durumların dışında kalan tüm rotalarda bu kısım işletilir.
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
