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
    public class GuestService : IService<Guest>
    {
        private readonly GuestRepository _guestRepository;

        public GuestService()
        {
        }

        public GuestService(GuestRepository gRep)
        {
            _guestRepository = gRep;
        }
        public void Add(Guest entity)
        {
            _guestRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _guestRepository.Delete(id);
        }

        public IEnumerable<Guest>? GetAll()
        {
            return _guestRepository.GetAll();
        }

        public IQueryable<Guest> GetAllQueryable()
        {
            return _guestRepository.GetAllQueryable();
        }

        public Guest? GetById(Guid id)
        {
            return _guestRepository.GetById(id);
        }

        public void Update(Guest entity)
        {
            _guestRepository.Update(entity);
        }
    }
}
