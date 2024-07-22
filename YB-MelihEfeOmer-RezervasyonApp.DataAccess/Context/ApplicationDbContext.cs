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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-13V6IU8;Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); //Melihin connection string'i
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DERU;Initial Catalog=HotelRezervationApp;Integrated Security=True;Trust Server Certificate=True"); // Ömer'in connection string'i
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

            modelBuilder.Entity<BRBookingGuest>()
                .HasKey(br => new { br.GuestId, br.BookingId });
            modelBuilder.Entity<BRBookingGuest>()
                .Ignore(br => br.Id);

            modelBuilder.Entity<Guest>()
                .HasIndex(g => g.IdentityNumber).IsUnique();

            var hotelId = Guid.NewGuid();
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = hotelId,
                    Name = "İbis",
                    Address = "İzmir/Alsancak",
                    Phone = "09998887766",
                    Email = "ibishotel@hotmail.com",
                    Stars = 4,
                    CheckinTime = new TimeOnly(8, 0),
                    CheckoutTime = new TimeOnly(23, 59)
                });

            var hotelId2 = Guid.NewGuid();
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = hotelId2,
                    Name = "Turkuaz",
                    Address = "İstanbul/Eminönü",
                    Phone = "55554443265",
                    Email = "turkuaz@hotmail.com",
                    Stars = 4,
                    CheckinTime = new TimeOnly(8, 0),
                    CheckoutTime = new TimeOnly(23, 59)
                });

            var staffId = Guid.NewGuid();
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = staffId,
                    HotelId = hotelId,
                    FirstName = "Ali",
                    LastName = "Vali",
                    Position = "Manager",
                    Salary = 50000,
                    DateOfBirth = new DateOnly(1970, 1, 1),
                    Phone = "09995554433",
                    Email = "ThisIsStaff@hotmail.com",
                    HireDate = new DateOnly(2010, 1, 1)
                });

            var staffId2 = Guid.NewGuid();
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = staffId2,
                    HotelId = hotelId2,
                    FirstName = "Murat",
                    LastName = "Duran",
                    Position = "Manager",
                    Salary = 50000,
                    DateOfBirth = new DateOnly(1980, 1, 1),
                    Phone = "09995554433",
                    Email = "ThisIsStaff2@hotmail.com",
                    HireDate = new DateOnly(1981, 1, 1)
                });

            var roomTypeId = Guid.NewGuid();
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    Id = roomTypeId,
                    Name = "Suit",
                    Description = "Suit type room",
                    PricePerNight = 1000,
                    Capacity = 2
                });

            var roomTypeId2 = Guid.NewGuid();
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    Id = roomTypeId2,
                    Name = "King",
                    Description = "King type room",
                    PricePerNight = 4000,
                    Capacity = 4
                });

            var roomTypeId3 = Guid.NewGuid();
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    Id = roomTypeId3,
                    Name = "Single",
                    Description = "Single type room",
                    PricePerNight = 500,
                    Capacity = 1
                });

            var roomId = Guid.NewGuid();
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id=roomId,
                    RoomNumber=101,
                    HotelId= hotelId,
                    RoomTypeId = roomTypeId,
                    Status="Avaliable"
                });

            var roomId2 = Guid.NewGuid();
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = roomId2,
                    RoomNumber=102,
                    HotelId = hotelId,
                    RoomTypeId = roomTypeId,
                    Status = "Avaliable"
                });

            var roomId3 = Guid.NewGuid();
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = roomId3,
                    RoomNumber = 201,
                    HotelId = hotelId,
                    RoomTypeId = roomTypeId2,
                    Status = "Avaliable"
                });

            var roomId4 = Guid.NewGuid();
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = roomId4,
                    RoomNumber = 202,
                    HotelId = hotelId,
                    RoomTypeId = roomTypeId3,
                    Status = "Avaliable"
                });

            var roomId5 = Guid.NewGuid();
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = roomId5,
                    RoomNumber = 101,
                    HotelId = hotelId2,
                    RoomTypeId = roomTypeId3,
                    Status = "Avaliable"
                });

            var roomId6 = Guid.NewGuid();
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = roomId6,
                    RoomNumber = 102,
                    HotelId = hotelId2,
                    RoomTypeId = roomTypeId3,
                    Status = "Avaliable"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}