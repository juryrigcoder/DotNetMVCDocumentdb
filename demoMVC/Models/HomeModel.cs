using System.Collections.Generic;

namespace demoMVC.Models
{
    public class HomeModel
    {
        public IEnumerable<ArticleModel> Items { get; private set; } //articles to display
        public Pagination PaginationInformation { get; private set; } //page information object for pagination

        /*
         * class constructors: first requires all fields to be set.
         */
        public HomeModel(IEnumerable<ArticleModel> _items, Pagination _paginationInformation)
        {
            Items = _items;
            PaginationInformation = _paginationInformation;
        }
    }
}
