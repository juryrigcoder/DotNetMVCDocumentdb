using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using demoMVC.Domain;

namespace demoMVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(int? page)
		{
			var pageItems = Consumables.ConsumableCollection().OrderByDescending(c => c.Created);
		    var articleModels = pageItems as IList<Models.ArticleModel> ?? pageItems.ToList();
		    var pager = new Pagination("Home", articleModels.Count, page);
		    var items = articleModels.Skip((int)((pager.CurrentPage - 1) * pager.PageSize)).Take((int)pager.PageSize);
		    var viewModel = new Models.HomeModel(items, pager);
		    return View(viewModel);
		}
	}
}
