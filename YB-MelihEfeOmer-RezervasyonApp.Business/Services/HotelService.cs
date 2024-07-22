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
    public class HotelService : IService<Hotel>
    {
        private readonly HotelRepository _hotelRepository;
        public HotelService(HotelRepository hRep)
        {
            _hotelRepository = hRep;
        }
        public void Add(Hotel entity)
        {
            _hotelRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _hotelRepository.Delete(id);
        }

        public IEnumerable<Hotel>? GetAll()
        {
            return _hotelRepository.GetAll();
        }

        public Hotel? GetById(Guid id)
        {
            return _hotelRepository.GetById(id);
        }

        public void Update(Hotel entity)
        {
            _hotelRepository.Update(entity);
        }
    }
}
