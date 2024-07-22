using System.ComponentModel.DataAnnotations;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class RoomType : BaseEntity
    {
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }
        public decimal PricePerNight { get; set; }
        public byte Capacity { get; set; }

        public ICollection<Room>? Rooms { get; set; }
    }
}