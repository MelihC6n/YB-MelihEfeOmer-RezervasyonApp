using System.Linq.Expressions;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Abstractions
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        IQueryable<T> GetAllQueryable(Expression<Func<T, bool>> filter = null);
    }
}
