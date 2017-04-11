using System.Collections.Generic;
using demoMVC.Models;
using LiteDB;
using System;

namespace demoMVC.Domain
{
    public class Consumables
    {
        // class method, consumables
        /// <summary>
        /// Returns a list of articles
        /// </summary>
        public static IEnumerable<ArticleModel> ConsumableCollection()
        {
            var articleList = new List<ArticleModel>();
            var dbstr = new DbConnection();
            using (var db = new LiteDatabase(dbstr.DbLocation))
            {
                var collection = db.GetCollection<ArticleModel>("Articles");
                var results = collection.FindAll();
                articleList.AddRange(results);
            }

            return articleList;
        }

        // class method, consumables
        /// <summary>
        /// Inserts a list of articles into database
        /// </summary>
        public static void ConsumablesInsert()
        {
            var dbstr = new DbConnection();
            using (var db = new LiteDatabase(dbstr.DbLocation))
            {
                var articles = db.GetCollection<ArticleModel>("Articles");
                for (var advance = 1; advance < 20; advance++)
                {
                    articles.Insert(new ArticleModel(_articleId:advance,_articleBody:"This is article " + advance, _title:"Title: " + advance,_created: DateTime.UtcNow));
                }
            }
        }
    }
}