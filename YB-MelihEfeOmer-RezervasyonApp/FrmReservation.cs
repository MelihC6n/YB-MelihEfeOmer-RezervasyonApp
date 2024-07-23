﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YB_MelihEfeOmer_RezervasyonApp.Business.Services;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp
{
    public partial class FrmReservation : Form
    {
        HotelService hotelService;
        HotelRepository hotelRepository;
        BookingService bookingService;
        BookingRepository bookingRepository;
        RoomService roomService;
        RoomRepository roomRepository;
        ApplicationDbContext context;
        RoomTypeService roomTypeService;
        RoomTypeRepository roomTypeRepository;
        public FrmReservation()
        {
            InitializeComponent();
            context = new();
            hotelRepository = new HotelRepository(context);
            hotelService = new HotelService(hotelRepository);
            bookingRepository = new BookingRepository(context);
            bookingService = new BookingService(bookingRepository);
            roomRepository = new RoomRepository(context);
            roomService = new RoomService(roomRepository);
            roomTypeRepository = new RoomTypeRepository(context);
            roomTypeService = new RoomTypeService(roomTypeRepository);
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            ListHotels();

        }

        private void ListHotels()
        {
            cmbOtelAdi.DataSource = hotelService.GetAll();
            cmbOtelAdi.DisplayMember = "Name";
            cmbOtelAdi.ValueMember = "Id";
            cmbOtelAdi.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOdaBul_Click(object sender, EventArgs e)
        {
            //var roomWithType = roomService.GetAllQueryable().Where(r=>r.HotelId==(Guid)cmbOtelAdi.SelectedValue);
            // dataGridView1.DataSource= roomWithType.ToList();
            var avaliableRooms = from r in context.Rooms
                                 where r.RoomType.Capacity >= nudKisiSayisi.Value && r.HotelId == (Guid)cmbOtelAdi.SelectedValue
                                 select new
                                 {
                                     r.HotelId,
                                     r.Hotel.Name,
                                     r.RoomNumber,
                                     r.RoomType.Capacity,
                                     r.Id,
                                     OdaTipi = r.RoomType.Name

                                 };
            //dataGridView1.DataSource = avaliableRooms.ToList();
            var freeBookings = from b in context.Bookings
                               where b.CheckinDate < DateOnly.FromDateTime(dtpCikisTarihi.Value) && b.CheckoutDate > DateOnly.FromDateTime(dtpGirisTarihi.Value)
                               select b;

            List<Guid> freeBookingIds = freeBookings.Select(b => b.Room.Id).ToList();

            var avaliableBookings = avaliableRooms.Where(r => !freeBookingIds.Contains(r.Id)).ToList();

            //var canSelectRoom = avaliableBookings.Where(r => r.OdaTipi == cmbOdaTipi.SelectedText);
            /*cmbOda.DataSource = avaliableBookings;
            cmbOda.DisplayMember = "RoomNumber";
            cmbOda.ValueMember = "Id";*/

            cmbOdaTipi.DataSource = avaliableBookings.GroupBy(x => x.OdaTipi).Select(x => new 
            {
                OdaTipi=x.Key,
                Odalar=x.ToList()
            }).ToList();
            cmbOdaTipi.DisplayMember = "OdaTipi";
            cmbOdaTipi.ValueMember = "OdaTipi";





        }

        private void btnRezervasyonaBasla_Click(object sender, EventArgs e)
        {

        }
    }
}
