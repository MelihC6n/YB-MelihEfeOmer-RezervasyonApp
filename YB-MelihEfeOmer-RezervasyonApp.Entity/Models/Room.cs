using System.ComponentModel.DataAnnotations;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }

        public Guid HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public Guid RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }

        [StringLength(20)]
        public string? Status { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}