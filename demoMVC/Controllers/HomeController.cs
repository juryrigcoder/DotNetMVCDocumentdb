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
			var articleModels = pageItems as IList<demoMVC.Models.ArticleModel> ?? pageItems.ToList();
			var pager = new Pagination("Home", articleModels.Count, page);

			var viewModel = new demoMVC.Models.HomeModel();
			{
				viewModel.Items =
					articleModels.Skip((int)((pager.CurrentPage - 1) * pager.PageSize)).Take((int)pager.PageSize);
				viewModel.PaginationInformation = pager;
			}
			return View(viewModel);
		}
	}
}
