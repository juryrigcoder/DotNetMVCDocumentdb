using System;
using LiteDB;

namespace demoMVC.Models
{
	public class ArticleModel
	{
	    [BsonIndex]
	    public int ArticleId { get; private set; }

		public string Title { get; private set; }

		public string ArticleBody { get; private set; }

	    [BsonIndex]
	    public DateTime Created  { get; private set; }

	    public ArticleModel(int _articleId, string _title, string _articleBody, DateTime _created)
	    {
	        ArticleId = _articleId;
	        Title = _title;
	        ArticleBody = _articleBody;
	        Created = _created;
	    }

	    public ArticleModel()
	    {

	    }
	}
}
