using YB_MelihEfeOmer_RezervasyonApp.Business.Abstractions;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Services
{
    public class BRBookingGuestService : IService<BRBookingGuest>
    {
        private readonly BRBookingGuestRepository _brBookingGuestRepository;
        public BRBookingGuestService(BRBookingGuestRepository brBookingGuestRepo)
        {
            _brBookingGuestRepository = brBookingGuestRepo;
        }
        public void Add(BRBookingGuest entity)
        {
            _brBookingGuestRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _brBookingGuestRepository.Delete(id);
        }

        public IEnumerable<BRBookingGuest>? GetAll()
        {
            return _brBookingGuestRepository.GetAll();
        }

        public IQueryable<BRBookingGuest> GetAllQueryable()
        {
            return _brBookingGuestRepository.GetAllQueryable();
        }

        public BRBookingGuest? GetById(Guid id)
        {
            return _brBookingGuestRepository.GetById(id);
        }

        public void Update(BRBookingGuest entity)
        {
            _brBookingGuestRepository.Update(entity);
        }
    }
}
