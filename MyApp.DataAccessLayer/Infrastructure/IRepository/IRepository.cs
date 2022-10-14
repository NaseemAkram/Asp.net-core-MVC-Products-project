using System.Linq.Expressions;

namespace MyApp.DataAccessLayer.Infrastructure.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetT(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);

    }
}
