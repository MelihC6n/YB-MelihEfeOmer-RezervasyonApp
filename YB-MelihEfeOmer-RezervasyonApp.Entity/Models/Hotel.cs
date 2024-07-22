using System.ComponentModel.DataAnnotations;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class Hotel : BaseEntity
    {
        [StringLength(255)]
        public string? Name { get; set; }

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(15)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }

        public byte Stars { get; set; }
        public TimeOnly CheckinTime { get; set; }
        public TimeOnly CheckoutTime { get; set; }

        public ICollection<Staff>? Staffs { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}