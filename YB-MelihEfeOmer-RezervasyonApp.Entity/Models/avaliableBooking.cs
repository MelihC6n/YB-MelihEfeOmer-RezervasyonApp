using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB_MelihEfeOmer_RezervasyonApp.Entity.Models
{
    public class avaliableBooking
    {
        public Guid HotelId { get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public byte Capacity { get; set; }
        public Guid Id { get; set; }
        public RoomType OdaTipi { get; set; }
        public string RoomTypeName { get; set; }
        public decimal PricePerNight { get; set; }

        public string DisplayRoomTypeInfo
        {
            get
            {
                return $"A:{RoomTypeName} B:{PricePerNight} C:{Capacity}";
            }
        }
    }
}
