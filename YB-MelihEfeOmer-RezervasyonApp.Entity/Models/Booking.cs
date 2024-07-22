using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class Booking : BaseEntity
    {
        public DateOnly CheckinDate { get; set; }
        public DateOnly CheckoutDate { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<Payment>? Payments { get; set; }
        public ICollection<Guest>? Guests { get; set; }

        public Guid GuestId { get; set; }
        public Guest? Guest { get; set; }

        //public Guid RoomId { get; set; }
        //public Room? Room { get; set; }
    }
}
