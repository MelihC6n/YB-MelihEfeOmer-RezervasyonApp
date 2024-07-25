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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YB_MelihEfeOmer_RezervasyonApp
{
    public partial class FrmSummary : Form
    {
        Guid _lastBookingId;
        private readonly HotelService hotelService;
        private readonly HotelRepository hotelRepository;
        private readonly BookingService bookingService;
        private readonly BookingRepository bookingRepository;
        private readonly RoomService roomService;
        private readonly RoomRepository roomRepository;
        private readonly ApplicationDbContext context;
        private readonly RoomTypeService roomTypeService;
        private readonly RoomTypeRepository roomTypeRepository;
        private readonly GuestService guestService;
        private readonly GuestRepository guestRepository;
        private readonly BRBookingGuestService BRBookingGuestService;
        private readonly BRBookingGuestRepository BRBookingGuestRepository;


        public FrmSummary(Guid lastBookingId)
        {

            InitializeComponent();
            context = new();
            _lastBookingId = lastBookingId;
            hotelRepository = new HotelRepository(context);
            hotelService = new HotelService(hotelRepository);
            bookingRepository = new BookingRepository(context);
            bookingService = new BookingService(bookingRepository);
            roomRepository = new RoomRepository(context);
            roomService = new RoomService(roomRepository);
            roomTypeRepository = new RoomTypeRepository(context);
            roomTypeService = new RoomTypeService(roomTypeRepository);
            guestRepository = new GuestRepository(context);
            guestService = new GuestService(guestRepository);
            BRBookingGuestRepository = new BRBookingGuestRepository(context);
            BRBookingGuestService = new BRBookingGuestService(BRBookingGuestRepository);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmSummary_Load(object sender, EventArgs e)
        {
            Booking booking = bookingService.GetById(_lastBookingId);
            Room room = roomService.GetById(booking.RoomId);
            RoomType roomType = roomTypeService.GetById(room.RoomTypeId);
            Hotel hotel = hotelService.GetById(room.HotelId);

            lblOtel.Text = hotel.Name;
            lblOdaNumara.Text = room.RoomNumber.ToString();
            lblTip.Text = roomType.Name.ToString();
            lblGiris.Text = booking.CheckinDate.ToString();
            lblCikis.Text = booking.CheckoutDate.ToString();
            List<Guest> misafirler = context.BRBookingGuests.Where(br => br.BookingId == _lastBookingId).Select(br => br.Guest).ToList();

            lblMisafirSayısı.Text = misafirler.Count.ToString() + " Kişi";

            lstMisafirler.View = View.Details;
            lstMisafirler.FullRowSelect = true;
            lstMisafirler.GridLines = true;
            lstMisafirler.Columns.Add("Kimlik No", 100);
            lstMisafirler.Columns.Add("Adı", 100);
            lstMisafirler.Columns.Add("Soyadı", 100);


            List<Guest> yukle = new List<Guest>();

            foreach (Guest guest in misafirler)
            {
                yukle.Add(new Guest { IdentityNumber = guest.IdentityNumber, FirstName = guest.FirstName, LastName = guest.LastName });
            }

            foreach (var guest in yukle)
            {
                string[] row = {
                    guest.IdentityNumber,
                    guest.FirstName,
                    guest.LastName
                };

                ListViewItem item = new ListViewItem(row);
                lstMisafirler.Items.Add(item);

            }
            lblTotalPrice.Text = booking.TotalPrice.ToString() + " TL";
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {

        }
    }
}
