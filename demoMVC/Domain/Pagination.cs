using System;

namespace demoMVC
{
    public class Pagination
    {
        //Constaint page size set in class
        private const decimal _PageSize = 5;
        //Public get and private set on properties
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public decimal PageSize { get; }
        public int TotalPages { get; private set; }
        public string Location { get; private set; }
        // Constructor setting private properties on instantiation
        /// <summary>
        /// Returns an object used to describe a group of articles.
        /// </summary>
        /// <param name="location">Current location in article group</param>
        /// <param name="totalItems">quantity of articles</param>
        /// <param name="page">page passed in query string, this can be nullable</param>
        public Pagination(string location, int totalItems, int? page)
        {
            TotalItems = totalItems;
            CurrentPage = page ?? 1;
            PageSize = _PageSize;
            TotalPages = (int)Math.Ceiling(totalItems / _PageSize);
            Location = location;
        }
    }
}
