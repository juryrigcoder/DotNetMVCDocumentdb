using System.Web;

namespace demoMVC.Domain
{
    public class DbConnection
    {
        //Public readonly field
        public readonly string DbLocation;
        // Constructor assigns value to readonly field
        /// <summary>
        /// Returns an object used to connect to database.
        /// </summary>
        public DbConnection()
        {
            DbLocation = HttpContext.Current.Server.MapPath(@"~/Database/projectdb.db");
        }
    }
}