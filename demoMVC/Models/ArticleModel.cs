using System;
using LiteDB;

namespace demoMVC.Models
{
	public class ArticleModel
	{
	    [BsonIndex]
	    public int ArticleId { get; set; }

		public string Title { get; set; }

		public string ArticleBody { get; set; }

	    [BsonIndex]
	    public DateTime Created  { get; set; }
	}
}
