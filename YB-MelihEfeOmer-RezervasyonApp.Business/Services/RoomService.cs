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
    public class RoomService : IService<Room>
    {
        private readonly RoomRepository _roomRepository;
        public RoomService(RoomRepository rRep)
        {
            _roomRepository = rRep;
        }
        public void Add(Room entity)
        {
            _roomRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _roomRepository.Delete(id);
        }

        public IEnumerable<Room>? GetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room? GetById(Guid id)
        {
            return _roomRepository.GetById(id);
        }

        public void Update(Room entity)
        {
            _roomRepository.Update(entity);
        }
    }
}
