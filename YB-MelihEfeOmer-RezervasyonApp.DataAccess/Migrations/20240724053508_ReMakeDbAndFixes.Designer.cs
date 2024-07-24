﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;

#nullable disable

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240724053508_ReMakeDbAndFixes")]
    partial class ReMakeDbAndFixes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            BookingId = new Guid("2f4d1a0a-4934-4c2d-9b00-c7f83a8acdf2"),
                            GuestId = new Guid("4df541dd-034f-4ff4-8c72-09d92652cfed"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3950),
                            IsActive = false,
                            IsDeleted = false,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookingId = new Guid("b16283d2-72c2-4699-8fee-53417c4c0712"),
                            GuestId = new Guid("4df541dd-034f-4ff4-8c72-09d92652cfed"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3978),
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
                            Id = new Guid("2f4d1a0a-4934-4c2d-9b00-c7f83a8acdf2"),
                            CheckinDate = new DateOnly(2024, 7, 23),
                            CheckoutDate = new DateOnly(2024, 7, 28),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3901),
                            IsActive = false,
                            IsDeleted = false,
                            RoomId = new Guid("5abab472-41ab-48f4-9bca-c095e9482569"),
                            TotalPrice = 0m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b16283d2-72c2-4699-8fee-53417c4c0712"),
                            CheckinDate = new DateOnly(2024, 8, 1),
                            CheckoutDate = new DateOnly(2024, 8, 2),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3926),
                            IsActive = false,
                            IsDeleted = false,
                            RoomId = new Guid("5abab472-41ab-48f4-9bca-c095e9482569"),
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
                            Id = new Guid("4df541dd-034f-4ff4-8c72-09d92652cfed"),
                            Address = "aa",
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3865),
                            DateOfBirth = new DateOnly(1999, 9, 9),
                            Email = "aaa",
                            FirstName = "Test",
                            IsActive = false,
                            IsDeleted = false,
                            LastName = "Test",
                            Phone = "5656",
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
                            Id = new Guid("8cfdab6f-36bd-42a8-af7f-da566a586715"),
                            Address = "İzmir/Alsancak",
                            CheckinTime = new TimeOnly(8, 0, 0),
                            CheckoutTime = new TimeOnly(23, 59, 0),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3417),
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
                            Id = new Guid("5ca0f94b-54a1-43d3-b0e3-83a038942f7c"),
                            Address = "İstanbul/Eminönü",
                            CheckinTime = new TimeOnly(8, 0, 0),
                            CheckoutTime = new TimeOnly(23, 59, 0),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3497),
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
                            Id = new Guid("5abab472-41ab-48f4-9bca-c095e9482569"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3713),
                            HotelId = new Guid("8cfdab6f-36bd-42a8-af7f-da566a586715"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeId = new Guid("b04545e0-776f-4630-9b05-83c8d3fb5647"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("45c01126-6939-4f59-8a9f-ed02fe3b4fed"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3742),
                            HotelId = new Guid("8cfdab6f-36bd-42a8-af7f-da566a586715"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeId = new Guid("b04545e0-776f-4630-9b05-83c8d3fb5647"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("585721b7-063b-4444-8fdc-d9d94ac9165e"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3767),
                            HotelId = new Guid("8cfdab6f-36bd-42a8-af7f-da566a586715"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 201,
                            RoomTypeId = new Guid("c4fca870-88cf-45f9-88ec-20c24b22da1c"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("66b5eb51-354f-498d-a3c5-51457f2826fa"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3788),
                            HotelId = new Guid("8cfdab6f-36bd-42a8-af7f-da566a586715"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 202,
                            RoomTypeId = new Guid("1382416c-df00-4799-9a1e-fc02abdfd876"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5dcbfa30-023d-4460-8689-9cb79368abb2"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3811),
                            HotelId = new Guid("5ca0f94b-54a1-43d3-b0e3-83a038942f7c"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeId = new Guid("1382416c-df00-4799-9a1e-fc02abdfd876"),
                            Status = "Avaliable",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("94a231ff-7fae-4313-9740-307e5e698bd8"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3836),
                            HotelId = new Guid("5ca0f94b-54a1-43d3-b0e3-83a038942f7c"),
                            IsActive = false,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeId = new Guid("1382416c-df00-4799-9a1e-fc02abdfd876"),
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
                            Id = new Guid("b04545e0-776f-4630-9b05-83c8d3fb5647"),
                            Capacity = (byte)2,
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3616),
                            Description = "Suit type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Suit",
                            PricePerNight = 1000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c4fca870-88cf-45f9-88ec-20c24b22da1c"),
                            Capacity = (byte)4,
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3649),
                            Description = "King type room",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "King",
                            PricePerNight = 4000m,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1382416c-df00-4799-9a1e-fc02abdfd876"),
                            Capacity = (byte)1,
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3683),
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
                            Id = new Guid("238a1aa2-c9d5-431a-9593-ff204afa58a2"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3536),
                            DateOfBirth = new DateOnly(1970, 1, 1),
                            Email = "ThisIsStaff@hotmail.com",
                            FirstName = "Ali",
                            HireDate = new DateOnly(2010, 1, 1),
                            HotelId = new Guid("8cfdab6f-36bd-42a8-af7f-da566a586715"),
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
                            Id = new Guid("3d75af45-d16c-440b-af0e-5effcc177834"),
                            CreatedTime = new DateTime(2024, 7, 24, 8, 35, 8, 164, DateTimeKind.Local).AddTicks(3579),
                            DateOfBirth = new DateOnly(1980, 1, 1),
                            Email = "ThisIsStaff2@hotmail.com",
                            FirstName = "Murat",
                            HireDate = new DateOnly(1981, 1, 1),
                            HotelId = new Guid("5ca0f94b-54a1-43d3-b0e3-83a038942f7c"),
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