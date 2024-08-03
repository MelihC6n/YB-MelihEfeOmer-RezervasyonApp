using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<BRBookingGuest> BRBookingGuests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-13V6IU8;Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); //Melihin connection string'i

            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DERU;Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); // Ömer'in connection string'i

            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-93GN49G\SQLEXPRESS;Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); //Efe'nin connection string'i

            optionsBuilder.UseSqlServer(@"Data Source=BPC9\SQLEXPRESS;Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); //Melih Bll Bilgisayar

            //optionsBuilder.UseSqlServer(@"Data Source = BPC18\SQLEXPRESS; Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); //mehmet bll bilgisayar

            //optionsBuilder.UseSqlServer(@"Data Source=BPC1\SQLEXPRESS;Initial Catalog=HotelRezervationAppV3;Integrated Security=True;Trust Server Certificate=True"); //Efe Bll Bilgisayar

            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H6C59L9\SQLEXPRESS;Initial Catalog= Besiktas;Integrated Security=True; Trust Server Certificate=True;"); //mehmet'in connection String'i
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>()
                .Property(s => s.Salary).HasPrecision(10, 2);

            modelBuilder.Entity<RoomType>()
                .Property(rt => rt.PricePerNight).HasPrecision(10, 2);

            modelBuilder.Entity<Booking>()
                .Property(b => b.TotalPrice).HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount).HasPrecision(10, 2);

            modelBuilder.Entity<Guest>()
                .HasIndex(g => g.IdentityNumber).IsUnique();

            modelBuilder.Entity<BRBookingGuest>()
                .HasKey(br => new { br.BookingId, br.GuestId });

            modelBuilder.Entity<BRBookingGuest>().Ignore(br => br.Id);

            var hotelId1 = Guid.NewGuid();
            var hotelId2 = Guid.NewGuid();
            var hotelId3 = Guid.NewGuid();

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = hotelId1,
                    Name = "Grand Horizon",
                    Address = "İstanbul/Beşiktaş",
                    Phone = "02121234567",
                    Email = "grandhorizon@example.com",
                    Stars = 4,
                    CheckinTime = new TimeOnly(14, 0),
                    CheckoutTime = new TimeOnly(12, 0)
                },
                new Hotel
                {
                    Id = hotelId2,
                    Name = "Seaside Resort",
                    Address = "Antalya/Kaleiçi",
                    Phone = "02428888888",
                    Email = "seasideresort@example.com",
                    Stars = 5,
                    CheckinTime = new TimeOnly(15, 0),
                    CheckoutTime = new TimeOnly(11, 0)
                },
                new Hotel
                {
                    Id = hotelId3,
                    Name = "Mountain Lodge",
                    Address = "Bolu/Yedigöller",
                    Phone = "03782567890",
                    Email = "mountainlodge@example.com",
                    Stars = 3,
                    CheckinTime = new TimeOnly(13, 0),
                    CheckoutTime = new TimeOnly(10, 0)
                }
            );

            var roomTypeId1 = Guid.NewGuid(); // Superior
            var roomTypeId2 = Guid.NewGuid(); // Penthouse
            var roomTypeId3 = Guid.NewGuid(); // Classic
            var roomTypeId4 = Guid.NewGuid(); // Executive Suite
            var roomTypeId5 = Guid.NewGuid(); // Standard Suite

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    Id = roomTypeId1,
                    Name = "Superior",
                    Description = "Spacious room with modern amenities",
                    PricePerNight = 1500,
                    Capacity = 2
                },
                new RoomType
                {
                    Id = roomTypeId2,
                    Name = "Royal S",
                    Description = "Luxurious top-floor room with city view",
                    PricePerNight = 3500,
                    Capacity = 4
                },
                new RoomType
                {
                    Id = roomTypeId3,
                    Name = "Classic",
                    Description = "Standard room with basic facilities",
                    PricePerNight = 800,
                    Capacity = 1
                },
                new RoomType
                {
                    Id = roomTypeId4,
                    Name = "Executive",
                    Description = "Suite with separate living and sleeping areas",
                    PricePerNight = 2500,
                    Capacity = 3
                },
                new RoomType
                {
                    Id = roomTypeId5,
                    Name = "Standard",
                    Description = "Comfortable suite with additional space",
                    PricePerNight = 2000,
                    Capacity = 3
                }
            );

            var roomId1 = Guid.NewGuid();
            var roomId2 = Guid.NewGuid();
            var roomId3 = Guid.NewGuid();
            var roomId4 = Guid.NewGuid();
            var roomId5 = Guid.NewGuid();
            var roomId6 = Guid.NewGuid();
            var roomId7 = Guid.NewGuid();
            var roomId8 = Guid.NewGuid();
            var roomId9 = Guid.NewGuid();

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = roomId1,
                    RoomNumber = 101,
                    HotelId = hotelId1,
                    RoomTypeId = roomTypeId1,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId2,
                    RoomNumber = 102,
                    HotelId = hotelId1,
                    RoomTypeId = roomTypeId2,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId3,
                    RoomNumber = 201,
                    HotelId = hotelId2,
                    RoomTypeId = roomTypeId3,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId4,
                    RoomNumber = 202,
                    HotelId = hotelId2,
                    RoomTypeId = roomTypeId4,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId5,
                    RoomNumber = 301,
                    HotelId = hotelId3,
                    RoomTypeId = roomTypeId5,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId6,
                    RoomNumber = 302,
                    HotelId = hotelId3,
                    RoomTypeId = roomTypeId1,
                    Status = "Occupied"
                },
                new Room
                {
                    Id = roomId7,
                    RoomNumber = 303,
                    HotelId = hotelId3,
                    RoomTypeId = roomTypeId2,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId8,
                    RoomNumber = 401,
                    HotelId = hotelId2,
                    RoomTypeId = roomTypeId5,
                    Status = "Available"
                },
                new Room
                {
                    Id = roomId9,
                    RoomNumber = 402,
                    HotelId = hotelId2,
                    RoomTypeId = roomTypeId3,
                    Status = "Occupied"
                }
            );

            var guestId1 = Guid.NewGuid();
            var guestId2 = Guid.NewGuid();
            var guestId3 = Guid.NewGuid();
            var guestId4 = Guid.NewGuid();
            var guestId5 = Guid.NewGuid();
            var guestId6 = Guid.NewGuid();
            var guestId7 = Guid.NewGuid();

            modelBuilder.Entity<Guest>().HasData(
                new Guest
                {
                    Id = guestId1,
                    IdentityNumber = "98765432101",
                    FirstName = "Ali",
                    LastName = "Kara",
                    DateOfBirth = new DateOnly(1985, 5, 12),
                    Address = "Ankara Çankaya",
                    Phone = "03121234567",
                    Email = "ali.kara@example.com"
                },
                new Guest
                {
                    Id = guestId2,
                    IdentityNumber = "87654321012",
                    FirstName = "Veli",
                    LastName = "Yılmaz",
                    DateOfBirth = new DateOnly(1990, 9, 23),
                    Address = "İstanbul Kadıköy",
                    Phone = "02129876543",
                    Email = "veli.yilmaz@example.com"
                },
                new Guest
                {
                    Id = guestId3,
                    IdentityNumber = "76543210923",
                    FirstName = "Ayşe",
                    LastName = "Yurt",
                    DateOfBirth = new DateOnly(1982, 4, 5),
                    Address = "İzmir Bornova",
                    Phone = "02325252525",
                    Email = "ayse.yurt@example.com"
                },
                new Guest
                {
                    Id = guestId4,
                    IdentityNumber = "65432109834",
                    FirstName = "Mehmet",
                    LastName = "Çelik",
                    DateOfBirth = new DateOnly(1975, 11, 15),
                    Address = "Antalya Lara",
                    Phone = "02426262626",
                    Email = "mehmet.celik@example.com"
                },
                new Guest
                {
                    Id = guestId5,
                    IdentityNumber = "54321098745",
                    FirstName = "Zeynep",
                    LastName = "Arslan",
                    DateOfBirth = new DateOnly(1993, 6, 19),
                    Address = "Bolu Merkez",
                    Phone = "03782567891",
                    Email = "zeynep.arslan@example.com"
                },
                new Guest
                {
                    Id = guestId6,
                    IdentityNumber = "43210987656",
                    FirstName = "Hüseyin",
                    LastName = "Koç",
                    DateOfBirth = new DateOnly(1988, 2, 8),
                    Address = "Trabzon Akçaabat",
                    Phone = "04622987654",
                    Email = "huseyin.koc@example.com"
                },
                new Guest
                {
                    Id = guestId7,
                    IdentityNumber = "32109876567",
                    FirstName = "Elif",
                    LastName = "Güven",
                    DateOfBirth = new DateOnly(1997, 8, 30),
                    Address = "Kayseri Melikgazi",
                    Phone = "03512345678",
                    Email = "elif.guven@example.com"
                }
            );

            decimal CalculateTotalPrice(DateOnly checkinDate, DateOnly checkoutDate, decimal pricePerNight)
            {
                int numberOfNights = (checkoutDate.DayNumber - checkinDate.DayNumber);
                return numberOfNights * pricePerNight;
            }

            var bookingId1 = Guid.NewGuid();
            var bookingId2 = Guid.NewGuid();
            var bookingId3 = Guid.NewGuid();
            var bookingId4 = Guid.NewGuid();
            var bookingId5 = Guid.NewGuid();
            var bookingId6 = Guid.NewGuid();
            var bookingId7 = Guid.NewGuid();

            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = bookingId1,
                    CheckinDate = new DateOnly(2024, 8, 1),
                    CheckoutDate = new DateOnly(2024, 8, 7),
                    RoomId = roomId1,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 7), 1500) // Superior Room
                },
                new Booking
                {
                    Id = bookingId2,
                    CheckinDate = new DateOnly(2024, 8, 10),
                    CheckoutDate = new DateOnly(2024, 8, 15),
                    RoomId = roomId2,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 8, 10), new DateOnly(2024, 8, 15), 3500) // Penthouse
                },
                new Booking
                {
                    Id = bookingId3,
                    CheckinDate = new DateOnly(2024, 9, 1),
                    CheckoutDate = new DateOnly(2024, 9, 4),
                    RoomId = roomId3,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 4), 800) // Classic Room
                },
                new Booking
                {
                    Id = bookingId4,
                    CheckinDate = new DateOnly(2024, 9, 15),
                    CheckoutDate = new DateOnly(2024, 9, 20),
                    RoomId = roomId4,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 20), 2500) // Executive Suite
                },
                new Booking
                {
                    Id = bookingId5,
                    CheckinDate = new DateOnly(2024, 10, 1),
                    CheckoutDate = new DateOnly(2024, 10, 8),
                    RoomId = roomId5,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 8), 2000) // Standard Suite
                },
                new Booking
                {
                    Id = bookingId6,
                    CheckinDate = new DateOnly(2024, 10, 5),
                    CheckoutDate = new DateOnly(2024, 10, 10),
                    RoomId = roomId7,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), 5000) // Penthouse
                },
                new Booking
                {
                    Id = bookingId7,
                    CheckinDate = new DateOnly(2024, 10, 15),
                    CheckoutDate = new DateOnly(2024, 10, 20),
                    RoomId = roomId8,
                    TotalPrice = CalculateTotalPrice(new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), 2000) // Standard Suite
                }
            );

            modelBuilder.Entity<BRBookingGuest>().HasData(
                new BRBookingGuest
                {
                    BookingId = bookingId1,
                    GuestId = guestId1
                },
                new BRBookingGuest
                {
                    BookingId = bookingId2,
                    GuestId = guestId2
                },
                new BRBookingGuest
                {
                    BookingId = bookingId3,
                    GuestId = guestId3
                },
                new BRBookingGuest
                {
                    BookingId = bookingId4,
                    GuestId = guestId4
                },
                new BRBookingGuest
                {
                    BookingId = bookingId5,
                    GuestId = guestId5
                },
                new BRBookingGuest
                {
                    BookingId = bookingId6,
                    GuestId = guestId6
                },
                new BRBookingGuest
                {
                    BookingId = bookingId7,
                    GuestId = guestId7
                }
            );

            var guestId8 = Guid.NewGuid();
            var guestId9 = Guid.NewGuid();
            var guestId10 = Guid.NewGuid();
            var guestId11 = Guid.NewGuid();
            var guestId12 = Guid.NewGuid();

            modelBuilder.Entity<Guest>().HasData(
                new Guest
                {
                    Id = guestId8,
                    IdentityNumber = "56789012345",
                    FirstName = "Derya",
                    LastName = "Kaya",
                    DateOfBirth = new DateOnly(1994, 11, 12),
                    Address = "Ankara Etimesgut",
                    Phone = "03134567890",
                    Email = "derya.kaya@example.com"
                },
                new Guest
                {
                    Id = guestId9,
                    IdentityNumber = "67890123456",
                    FirstName = "Gökhan",
                    LastName = "Aydın",
                    DateOfBirth = new DateOnly(1987, 6, 25),
                    Address = "İzmir Karşıyaka",
                    Phone = "02345678901",
                    Email = "gokhan.aydin@example.com"
                },
                new Guest
                {
                    Id = guestId10,
                    IdentityNumber = "78901234567",
                    FirstName = "Eylül",
                    LastName = "Yalçın",
                    DateOfBirth = new DateOnly(1995, 3, 8),
                    Address = "Bursa Osmangazi",
                    Phone = "02225678901",
                    Email = "eylul.yalcin@example.com"
                },
                new Guest
                {
                    Id = guestId11,
                    IdentityNumber = "89012345678",
                    FirstName = "Mert",
                    LastName = "Yılmaz",
                    DateOfBirth = new DateOnly(1989, 7, 20),
                    Address = "Konya Meram",
                    Phone = "03325678901",
                    Email = "mert.yilmaz@example.com"
                },
                new Guest
                {
                    Id = guestId12,
                    IdentityNumber = "90123456789",
                    FirstName = "Seda",
                    LastName = "Demirtaş",
                    DateOfBirth = new DateOnly(1992, 10, 30),
                    Address = "İstanbul Beylikdüzü",
                    Phone = "02124567890",
                    Email = "seda.demirtas@example.com"
                }
            );

            modelBuilder.Entity<BRBookingGuest>().HasData(
    // Penthouse rezervasyonu (bookingId2) için misafirler
    new BRBookingGuest
    {
        BookingId = bookingId2,
        GuestId = guestId8
    },
    new BRBookingGuest
    {
        BookingId = bookingId2,
        GuestId = guestId9
    },
    new BRBookingGuest
    {
        BookingId = bookingId2,
        GuestId = guestId10
    },

    // Penthouse rezervasyonu (bookingId6) için misafirler
    new BRBookingGuest
    {
        BookingId = bookingId6,
        GuestId = guestId12
    },

    // Executive Suite rezervasyonu (bookingId4) için misafirler
    new BRBookingGuest
    {
        BookingId = bookingId4,
        GuestId = guestId8
    },
    new BRBookingGuest
    {
        BookingId = bookingId4,
        GuestId = guestId10
    },

    // Executive Suite rezervasyonu (bookingId7) için misafirler
    new BRBookingGuest
    {
        BookingId = bookingId7,
        GuestId = guestId9
    },
    new BRBookingGuest
    {
        BookingId = bookingId7,
        GuestId = guestId12
    }
);

            base.OnModelCreating(modelBuilder);
        }
    }
}