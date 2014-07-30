using System.Data.Entity;

namespace MVC4AndEF6WithAngular.Data.Contexts
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(string connection): base(connection)
        {
            Database.SetInitializer<MySqlContext>(null);
        }
    }
}