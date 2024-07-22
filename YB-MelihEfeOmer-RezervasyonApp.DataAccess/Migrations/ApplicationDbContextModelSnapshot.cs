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
                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("GuestId", "BookingId");

                    b.HasIndex("BookingId");

                    b.ToTable("BRBookingGuest");
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

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");
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
                            Id = new Guid("99326cba-e915-4711-81de-375352b8659a"),
                            Address = "İzmir/Alsancak",
                            CheckinTime = new TimeOnly(8, 0, 0),
                            CheckoutTime = new TimeOnly(23, 59, 0),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8032),
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
                            Id = new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"),
                            Address = "İstanbul/Eminönü",
                            CheckinTime = new TimeOnly(8, 0, 0),
                            CheckoutTime = new TimeOnly(23, 59, 0),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8104),
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
                            Id = new Guid("eccff4b6-7b8b-4d86-8278-0cb989e389c6"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8359),
                            HotelId = new Guid("99326cba-e915-4711-81de-375352b8659a"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeId = new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ba754e20-15a0-48d7-b8e7-bfbb434178df"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8414),
                            HotelId = new Guid("99326cba-e915-4711-81de-375352b8659a"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeId = new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d1441bd8-c51f-4080-9a73-036efa06adf1"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8450),
                            HotelId = new Guid("99326cba-e915-4711-81de-375352b8659a"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 201,
                            RoomTypeId = new Guid("aa0c0a7a-0e98-47cc-95ce-3e4fbaa0734c"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d46f4910-9845-4a6e-9de5-468c6c319e77"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8484),
                            HotelId = new Guid("99326cba-e915-4711-81de-375352b8659a"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 202,
                            RoomTypeId = new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a8a15b45-5d89-4975-b004-6c31ccd6531e"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8518),
                            HotelId = new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeId = new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("66d1a3aa-46b0-4056-8a2d-53b40e28d866"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8560),
                            HotelId = new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeId = new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"),
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
                            Id = new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"),
                            Capacity = (byte)2,
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8240),
                            Description = "Suit type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Suit",
                            PricePerNight = 1000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("aa0c0a7a-0e98-47cc-95ce-3e4fbaa0734c"),
                            Capacity = (byte)4,
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8281),
                            Description = "King type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "King",
                            PricePerNight = 4000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"),
                            Capacity = (byte)1,
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8316),
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
                            Id = new Guid("2a1b2c33-fdc4-4d43-9bf8-2c09ada4327c"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8142),
                            DateOfBirth = new DateOnly(1970, 1, 1),
                            Email = "ThisIsStaff@hotmail.com",
                            FirstName = "Ali",
                            HireDate = new DateOnly(2010, 1, 1),
                            HotelId = new Guid("99326cba-e915-4711-81de-375352b8659a"),
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
                            Id = new Guid("c5b16e84-c3b7-49f4-a31d-2758265eab4f"),
                            CreatedTime = new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8193),
                            DateOfBirth = new DateOnly(1980, 1, 1),
                            Email = "ThisIsStaff2@hotmail.com",
                            FirstName = "Murat",
                            HireDate = new DateOnly(1981, 1, 1),
                            HotelId = new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"),
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
                        .WithMany("Guests")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Guest", "Guest")
                        .WithMany("Bookings")
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
                        .HasForeignKey("RoomId");

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
                    b.Navigation("Guests");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("YB_MelihEfeOmer_RezervasyonApp.Entity.Models.Guest", b =>
                {
                    b.Navigation("Bookings");
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
