using System.Web;

namespace demoMVC.Domain
{
    public class DbConnection
    {
        public static string DbLocation = HttpContext.Current.Server.MapPath(@"~/Database/projectdb.db");
    }
}