using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateOnly PaymentDate { get; set; }

        [StringLength(50)]
        public string? PaymentMethod { get; set; }
        public Guid BookingId { get; set; }
        public Booking? Booking { get; set; }

    }
}
