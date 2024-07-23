using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Business.Abstractions;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Services
{
    public class StaffService : IService<Staff>
    {
        private readonly StaffRepository _staffRepository;
        public StaffService(StaffRepository sRep)
        {
            _staffRepository = sRep;
        }
        public void Add(Staff entity)
        {
            _staffRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _staffRepository.Delete(id);
        }

        public IEnumerable<Staff>? GetAll()
        {
            return _staffRepository.GetAll();
        }

        public IQueryable<Staff> GetAllQueryable()
        {
            return _staffRepository.GetAllQueryable();
        }

        public Staff? GetById(Guid id)
        {
            return _staffRepository.GetById(id);
        }

        public void Update(Staff entity)
        {
            _staffRepository.Update(entity);
        }
    }
}
