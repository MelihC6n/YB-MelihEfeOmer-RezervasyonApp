using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class Guest : BaseEntity
    {
        [StringLength(11)]
        public string? IdentityNumber { get; set; }

        [StringLength(50)] 
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? LastName { get; set; }

        public DateOnly DateOfBirth { get; set; }

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(15)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }

        public ICollection<BRBookingGuest>? BRBookingGuests { get; set; }
    }
}
