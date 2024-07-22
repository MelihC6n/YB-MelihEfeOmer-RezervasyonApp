using Microsoft.EntityFrameworkCore;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Abstractions;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        //private readonly ApplicationDbContext _context;
        //private readonly DbSet<T> _dbSet;

        //public GenericRepository(ApplicationDbContext context)
        //{
        //    _context = context;
        //    _dbSet = _context.Set<T>();
        //}
        public void Add(T entity)
        {
            //_dbSet.Add(entity);
            //_context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            //_dbSet.Remove(GetById(id));
            //_context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            //return _dbSet.ToList();
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            //var entity = _dbSet.Find(id);

            //if (entity == null)
            //{
            //    throw new Exception("Böyle bir kayıt bulunamadı.");
            //}
            //return entity;
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            //_context.SaveChanges();
        }
    }

}
