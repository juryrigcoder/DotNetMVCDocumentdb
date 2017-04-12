using System;
using LiteDB;

namespace demoMVC.Models
{
	public class ArticleModel
	{
	    [BsonIndex]//litedb attribute to mark your entity property to auto create index when queried
	    public int ArticleId { get; set; }// unique id

		public string Title { get; set; }// article title

		public string ArticleBody { get; set; }// document or article content

	    [BsonIndex]//litedb attribute to mark your entity property to auto create index when queried
	    public DateTime Created  { get; set; }// date creted

	    /*
         * class constructors: first requires all fields to be set. included blank constructor for model binding
         */
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
