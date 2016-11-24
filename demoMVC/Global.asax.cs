using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using demoMVC.Domain;

namespace demoMVC
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		    //Consumables.ConsumablesInsert();
		}
	}
}
