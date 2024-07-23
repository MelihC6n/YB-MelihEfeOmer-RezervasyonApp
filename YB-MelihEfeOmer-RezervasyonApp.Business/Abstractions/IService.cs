using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Abstractions
{
    public interface IService<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id); //void Delete(T entity);
        T? GetById(Guid id); //T GetById(string id);
        IEnumerable<T>? GetAll(); //List<T> GetAll();
        IQueryable<T> GetAllQueryable();
    }
}
