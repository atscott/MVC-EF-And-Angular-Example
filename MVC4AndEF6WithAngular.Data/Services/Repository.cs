using System.Data.Entity;
using System.Linq;

namespace InstiselDashboard.Data.Services
{
    public interface IRepository<out T> where T : class
    {
        IQueryable<T> Query();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private IDbSet<T> EntityContext { get; set; }

        public Repository(DbContext dbContext)
        {
            EntityContext = dbContext.Set<T>();
        }

        public IQueryable<T> Query()
        {
            return EntityContext;
        }
    }
}