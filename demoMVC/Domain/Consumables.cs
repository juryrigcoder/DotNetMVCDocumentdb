using System.Collections.Generic;
using demoMVC.Models;
using LiteDB;
using System;

namespace demoMVC.Domain
{
    public class Consumables
    {
        public static IEnumerable<ArticleModel> ConsumableCollection()
        {
            List<ArticleModel> ArticleList = new List<ArticleModel>();
            using (var db = new LiteDatabase(DbConnection.DbLocation))
            {
                var collection = db.GetCollection<ArticleModel>("Articles");
                var results = collection.FindAll();
                ArticleList.AddRange(results);
            }

            return ArticleList;
        }

        public static void ConsumablesInsert()
        {
            using (var db = new LiteDatabase(DbConnection.DbLocation))
            {
                var articles = db.GetCollection<ArticleModel>("Articles");
                for (int advance = 1; advance < 20; advance++)
                {
                    articles.Insert(new ArticleModel(){ArticleId = advance, ArticleBody = "This is article " + advance, Title = "Title: " + advance, Created = DateTime.UtcNow});
                }
            }
        }
    }
}