using Asp.net_core_MVC_Products_project.Data;
using Microsoft.EntityFrameworkCore;
using MyApp.DataAccessLayer.Infrastructure.IRepository;
using System.Linq.Expressions;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _dbset;

        public Repository(ApplicationDbContext context)
        {

            _context = context;
            _dbset = _context.Set<T>();

        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            _dbset.RemoveRange(entity);
        }

        public T GetT(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }
    }
}
