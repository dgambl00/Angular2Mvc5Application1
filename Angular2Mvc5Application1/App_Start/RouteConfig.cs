using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Angular2Mvc5Application1 {
  public class RouteConfig {
    public static void RegisterRoutes(RouteCollection routes) {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      var dataTokens = new RouteValueDictionary();
      var ns = new string[] { "Angular2Mvc5Application1.Controllers" };
      dataTokens["Namespaces"] = ns;

      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, ns }
      );
    }
  }
}
