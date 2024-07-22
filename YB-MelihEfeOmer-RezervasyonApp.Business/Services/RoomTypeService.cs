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
    public class RoomTypeService : IService<RoomType>
    {
        private readonly RoomTypeRepository _roomTypeRepository;
        public RoomTypeService(RoomTypeRepository rtRep)
        {
            _roomTypeRepository = rtRep;
        }
        public void Add(RoomType entity)
        {
            _roomTypeRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _roomTypeRepository.Delete(id);
        }

        public IEnumerable<RoomType>? GetAll()
        {
            return _roomTypeRepository.GetAll();
        }

        public RoomType? GetById(Guid id)
        {
            return _roomTypeRepository.GetById(id);
        }

        public void Update(RoomType entity)
        {
            _roomTypeRepository.Update(entity);
        }
    }
}
