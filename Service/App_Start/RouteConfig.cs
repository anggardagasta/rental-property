using System.Web.Mvc;
using System.Web.Routing;

namespace Service
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{location}",
				defaults: new { controller = "Home", action = "Index", location = UrlParameter.Optional }
			);
		}
	}
}
