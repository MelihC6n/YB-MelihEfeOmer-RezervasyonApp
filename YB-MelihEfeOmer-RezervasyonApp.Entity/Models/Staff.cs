using System.ComponentModel.DataAnnotations;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class Staff : BaseEntity
    {
        [StringLength(50)]
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? LastName { get; set; }

        [StringLength(50)]
        public string? Position { get; set; }

        public decimal Salary { get; set; }
        public DateOnly DateOfBirth { get; set; }

        [StringLength(15)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }

        public DateOnly HireDate { get; set; }

        public Guid HotelId { get; set; }
        public Hotel? Hotel { get; set; }

    }
}
