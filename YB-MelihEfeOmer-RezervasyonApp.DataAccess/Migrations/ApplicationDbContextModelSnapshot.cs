﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;

#nullable disable

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.BRBookingGuest", b =>
                {
                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingId", "GuestId");

                    b.HasIndex("GuestId");

                    b.ToTable("BRBookingGuests");

                    b.HasData(
                        new
                        {
                            BookingId = new Guid("25479c99-babb-4b95-b1a7-34097708a61f"),
                            GuestId = new Guid("24269b24-8c02-443b-807c-265d64d46e8c"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1932),
                            IsActive = false,
                            IsDeleted = false,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookingId = new Guid("9615b8a8-e68d-42f4-8615-14c0e2e679a4"),
                            GuestId = new Guid("24269b24-8c02-443b-807c-265d64d46e8c"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1943),
                            IsActive = false,
                            IsDeleted = false,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("CheckinDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("CheckoutDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25479c99-babb-4b95-b1a7-34097708a61f"),
                            CheckinDate = new DateOnly(2024, 7, 23),
                            CheckoutDate = new DateOnly(2024, 7, 28),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1907),
                            IsActive = false,
                            IsDeleted = false,
                            RoomId = new Guid("190a8926-536b-4668-8f46-090534a18142"),
                            TotalPrice = 0m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("9615b8a8-e68d-42f4-8615-14c0e2e679a4"),
                            CheckinDate = new DateOnly(2024, 8, 1),
                            CheckoutDate = new DateOnly(2024, 8, 2),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1918),
                            IsActive = false,
                            IsDeleted = false,
                            RoomId = new Guid("190a8926-536b-4668-8f46-090534a18142"),
                            TotalPrice = 0m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Guest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdentityNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdentityNumber")
                        .IsUnique()
                        .HasFilter("[IdentityNumber] IS NOT NULL");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24269b24-8c02-443b-807c-265d64d46e8c"),
                            Address = "İstanbul Beylikdüzü Bişeyler mahallesi",
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1893),
                            DateOfBirth = new DateOnly(1999, 9, 9),
                            Email = "aaa@test.com",
                            FirstName = "Ali",
                            IdentityNumber = "61006494392",
                            IsActive = false,
                            IsDeleted = false,
                            LastName = "Veli",
                            Phone = "56569856",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<TimeOnly>("CheckinTime")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("CheckoutTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<byte>("Stars")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"),
                            Address = "İzmir/Alsancak",
                            CheckinTime = new TimeOnly(8, 0, 0),
                            CheckoutTime = new TimeOnly(23, 59, 0),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1593),
                            Email = "ibishotel@hotmail.com",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "İbis",
                            Phone = "09998887766",
                            Stars = (byte)4,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"),
                            Address = "İstanbul/Eminönü",
                            CheckinTime = new TimeOnly(8, 0, 0),
                            CheckoutTime = new TimeOnly(23, 59, 0),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1648),
                            Email = "turkuaz@hotmail.com",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Turkuaz",
                            Phone = "55554443265",
                            Stars = (byte)4,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("RoomTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("190a8926-536b-4668-8f46-090534a18142"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1829),
                            HotelId = new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeId = new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("86c036b1-faba-470d-8860-43fd96ae1588"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1839),
                            HotelId = new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeId = new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("99b55501-433f-4fa5-843e-135ea0543995"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1850),
                            HotelId = new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 201,
                            RoomTypeId = new Guid("3cf45b63-53d6-4325-abca-06570b622a61"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("84d31dfa-f6c7-44ff-bd84-fd8380ee5a36"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1860),
                            HotelId = new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 202,
                            RoomTypeId = new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("8eea7d60-5cca-42ad-a0c1-8ebe777fb1c0"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1869),
                            HotelId = new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeId = new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("87078621-e5eb-468c-a90b-cc6ad0ff6b64"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1878),
                            HotelId = new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeId = new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.RoomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Capacity")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PricePerNight")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"),
                            Capacity = (byte)2,
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1792),
                            Description = "Suit type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Suit",
                            PricePerNight = 1000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3cf45b63-53d6-4325-abca-06570b622a61"),
                            Capacity = (byte)4,
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1807),
                            Description = "King type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "King",
                            PricePerNight = 4000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"),
                            Capacity = (byte)1,
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1817),
                            Description = "Single type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Single",
                            PricePerNight = 500m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("HireDate")
                        .HasColumnType("date");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e4e58589-134e-4cf9-940a-a1ea7c9a1fc4"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1750),
                            DateOfBirth = new DateOnly(1970, 1, 1),
                            Email = "ThisIsStaff@hotmail.com",
                            FirstName = "Ali",
                            HireDate = new DateOnly(2010, 1, 1),
                            HotelId = new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"),
                            IsActive = false,
                            IsDeleted = false,
                            LastName = "Vali",
                            Phone = "09995554433",
                            Position = "Manager",
                            Salary = 50000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f297e6e2-480d-4910-92f4-6e13f5a4fd03"),
                            CreatedTime = new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1777),
                            DateOfBirth = new DateOnly(1980, 1, 1),
                            Email = "ThisIsStaff2@hotmail.com",
                            FirstName = "Murat",
                            HireDate = new DateOnly(1981, 1, 1),
                            HotelId = new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"),
                            IsActive = false,
                            IsDeleted = false,
                            LastName = "Duran",
                            Phone = "09995554433",
                            Position = "Manager",
                            Salary = 50000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.BRBookingGuest", b =>
                {
                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Booking", "Booking")
                        .WithMany("BRBookingGuests")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Guest", "Guest")
                        .WithMany("BRBookingGuests")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Booking", b =>
                {
                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Payment", b =>
                {
                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Booking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Room", b =>
                {
                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Staff", b =>
                {
                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Hotel", "Hotel")
                        .WithMany("Staffs")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Booking", b =>
                {
                    b.Navigation("BRBookingGuests");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Guest", b =>
                {
                    b.Navigation("BRBookingGuests");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
