using System;
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
            var roomWithType = roomService.GetAllQueryable().Where(r=>r.HotelId==(Guid)cmbOtelAdi.SelectedValue);
            // dataGridView1.DataSource= roomWithType.ToList();
            var avaliableRooms = from r in context.Rooms
                                 where r.RoomType.Capacity >= nudKisiSayisi.Value && r.HotelId == (Guid)cmbOtelAdi.SelectedValue
                                 select r; /*new 
                                 { 
                                     r.HotelId,
                                     r.Hotel.Name,
                                     r.RoomNumber,
                                     r.RoomType.Capacity,
                                     r.Id

                                 };*/
            //dataGridView1.DataSource = avaliableRooms.ToList();
            var freeBookings = from b in context.Bookings
                               where b.CheckinDate > DateOnly.FromDateTime(dtpCikisTarihi.Value) && b.CheckoutDate < DateOnly.FromDateTime(dtpGirisTarihi.Value)
                               select b;
            dataGridView1.DataSource= freeBookings.ToList();

            var avaliableBookings = avaliableRooms.ToList().Where(r => !freeBookings.ToList().Contains(r.Id));
            

        }
    }
}
