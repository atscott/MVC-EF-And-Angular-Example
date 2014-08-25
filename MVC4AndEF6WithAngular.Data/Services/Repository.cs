using System.Data.Entity;
using System.Linq;

namespace MVC4AndEF6WithAngular.Data.Services
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Query();
        IDbSet<T> Get();
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

        public IDbSet<T> Get()
        {
            return EntityContext;
        }
    }
}