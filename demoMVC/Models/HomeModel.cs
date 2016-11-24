using System.Collections.Generic;
using demoMVC.Domain;

namespace demoMVC.Models
{
	public class HomeModel
	{
		public IEnumerable<ArticleModel> Items { get; set; } //articles to display
		public Pagination PaginationInformation { get; set; } //page information object for pagination
	}
}
