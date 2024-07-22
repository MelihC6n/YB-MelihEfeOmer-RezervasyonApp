using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class BRBookingGuest : BaseEntity
    {
        public Booking? Booking { get; set; }
        public Guid BookingId { get; set; }

        public Guest? Guest { get; set; }
        public Guid GuestId { get; set; }
    }
}
