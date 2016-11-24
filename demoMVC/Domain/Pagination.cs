using System;

namespace demoMVC.Domain
{
	public class Pagination
	{
		public const decimal pageSize = 5;

		public int TotalItems { get; set; }
		public int CurrentPage { get; set; }
		public decimal PageSize { get; }
		public int TotalPages { get; set; }
		public string Location { get; set; }

		public Pagination(string location, int totalItems, int? page)
		{
			TotalItems = totalItems;
			CurrentPage = page ?? 1;
			PageSize = pageSize;
			TotalPages = (int)Math.Ceiling(totalItems / pageSize);
			Location = location;
		}
	}
}
