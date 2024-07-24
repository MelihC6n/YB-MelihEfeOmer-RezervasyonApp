using Microsoft.EntityFrameworkCore;
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
    public class BookingService : IService<Booking>
    {
        private readonly BookingRepository _bookingRepository;
        public BookingService(BookingRepository bRep)
        {
            _bookingRepository = bRep;
        }
        public void Add(Booking entity)
        {
            _bookingRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _bookingRepository.Delete(id);
        }

        public IEnumerable<Booking>? GetAll()
        {
            return _bookingRepository.GetAll();
        }

        public IQueryable<Booking> GetAllQueryable()
        {
            return _bookingRepository.GetAllQueryable();
        }

        public Booking? GetById(Guid id)
        {
            return _bookingRepository.GetById(id);  
        }

        public void Update(Booking entity)
        {
            _bookingRepository.Update(entity);
        }

        
    }
}
