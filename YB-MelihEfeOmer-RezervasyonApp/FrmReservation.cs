using Microsoft.IdentityModel.Tokens;
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
        RoomTypeService roomTypeService;
        RoomTypeRepository roomTypeRepository;
        GuestService guestService;
        GuestRepository guestRepository;
        BRBookingGuestService BRBookingGuestService;
        BRBookingGuestRepository BRBookingGuestRepository;

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
            guestRepository = new GuestRepository(context);
            guestService = new GuestService(guestRepository);
            BRBookingGuestRepository = new BRBookingGuestRepository(context);
            BRBookingGuestService = new BRBookingGuestService(BRBookingGuestRepository);
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            dgvRezervasyonlar.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            ListHotels();
            IQueryable<object> showBookings = FillReservations(Guid.Empty);

            dgvRezervasyonlar.DataSource = showBookings.ToList();

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

        List<avaliableBooking> avaliableBooking = new List<avaliableBooking>();

        private void btnOdaBul_Click(object sender, EventArgs e)
        {
            grpRooms.Enabled = true;
            //var roomWithType = roomService.GetAllQueryable().Where(r=>r.HotelId==(Guid)cmbOtelAdi.SelectedValue);
            // dataGridView1.DataSource= roomWithType.ToList();
            var avaliableRooms = from r in context.Rooms
                                 where r.RoomType.Capacity >= nudKisiSayisi.Value && r.HotelId == (Guid)cmbOtelAdi.SelectedValue
                                 select new avaliableBooking
                                 {
                                     HotelId = r.HotelId,
                                     Name = r.Hotel.Name,
                                     RoomNumber = r.RoomNumber,
                                     Capacity = (byte)r.RoomType.Capacity,
                                     Id = r.Id,
                                     OdaTipi = r.RoomType
                                 };
            //dataGridView1.DataSource = avaliableRooms.ToList();
            var freeBookings = from b in context.Bookings
                               where b.CheckinDate <= DateOnly.FromDateTime(dtpCikisTarihi.Value) && b.CheckoutDate >= DateOnly.FromDateTime(dtpGirisTarihi.Value)
                               select b;

            List<Guid> freeBookingIds = freeBookings.Select(b => b.Room.Id).ToList();


            avaliableBooking = avaliableRooms.Where(r => !freeBookingIds.Contains(r.Id)).ToList();

            //var canSelectRoom = avaliableBookings.Where(r => r.OdaTipi == cmbOdaTipi.SelectedText);
            /*cmbOda.DataSource = avaliableBookings;
            cmbOda.DisplayMember = "RoomNumber";
            cmbOda.ValueMember = "Id";*/

            cmbOdaTipi.DisplayMember = "OdaTipi";
            cmbOdaTipi.ValueMember = "OdaTipiId";

            cmbOdaTipi.DataSource = avaliableBooking.GroupBy(x => new { x.OdaTipi.Name, x.OdaTipi.Id }).Select(x => new
            {
                OdaTipi = x.Key.Name,
                OdaTipiId = x.Key.Id,
                Odalar = x.ToList()
            }).ToList();

        }
        private void btnRezervasyonaBasla_Click(object sender, EventArgs e)
        {
            grpReservationDetails.Enabled = false;
            grpPersonalDetails.Enabled = true;
            MessageBox.Show($"{nudKisiSayisi.Value} kişinin bilgilerini giriniz.", "Misafir Bilgi Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpPersonalDetails.Text = $"{misafirSayaci + 1}. Misafirin Bilgilerini Giriniz";
            kisiSayisi = Convert.ToInt32(nudKisiSayisi.Value);

            misafirler = new List<Guest>(new Guest[kisiSayisi]);

            if (kisiSayisi > 1)
            {
                btnKaydet.Enabled = false;
            }
        }

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdaTipi.SelectedValue != null)
            {
                cmbOda.DisplayMember = "RoomNumber";
                cmbOda.ValueMember = "Id";
                cmbOda.DataSource = avaliableBooking.Where(ab => (Guid)ab.OdaTipi.Id == (Guid)cmbOdaTipi.SelectedValue).ToList();
            }
        }

        List<Guest> misafirler;
        int kisiSayisi;
        int misafirSayaci = 0;
        Guid lastBookingId;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MisafirBilgileriniKontrolEt();

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Booking booking = new Booking()
                    {
                        CheckinDate = DateOnly.FromDateTime(dtpGirisTarihi.Value),
                        CheckoutDate = DateOnly.FromDateTime(dtpCikisTarihi.Value),
                        TotalPrice = 100,
                        RoomId = (Guid)cmbOda.SelectedValue,
                    };

                    bookingService.Add(booking);

                    foreach (var m in misafirler)
                    {
                        Guest guest = new Guest()
                        {
                            IdentityNumber = m.IdentityNumber,
                            FirstName = m.FirstName,
                            LastName = m.LastName,
                            DateOfBirth = m.DateOfBirth,
                            Address = m.Address,
                            Phone = m.Phone,
                            Email = m.Email,
                        };

                        guestService.Add(guest);

                        BRBookingGuest bRBookingGuest = new BRBookingGuest()
                        {
                            Booking = booking,
                            BookingId = booking.Id,

                            GuestId = guest.Id
                        };

                        BRBookingGuestService.Add(bRBookingGuest);
                    }
                    transaction.Commit();
                    lastBookingId = booking.Id;
                    MessageBox.Show("Ekleme başarılı");
                    FillDataGridWithReservations();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void FillDataGridWithReservations()
        {
            dgvRezervasyonlar.DataSource = FillReservations(lastBookingId).ToList();
        }

        private IQueryable<object> FillReservations(Guid lastBookingId)
        {
            dgvRezervasyonlar.DataSource = null;
            if (lastBookingId != Guid.Empty)
            {
                return from b in context.Bookings
                       where b.Id == lastBookingId
                       join br in context.BRBookingGuests on b.Id equals br.BookingId
                       join g in context.Guests on br.GuestId equals g.Id
                       join r in context.Rooms on b.RoomId equals r.Id
                       select new
                       {
                           CheckinDate = b.CheckinDate,
                           CheckoutDate = b.CheckoutDate,
                           RoomNumber = b.Room.RoomNumber,
                           TotalPrice = b.TotalPrice,
                           Guest = g.FirstName + g.LastName,
                           Phone = g.Phone,
                           OdaTipi = r.RoomType.Name
                       };
            }
            else
            {
                return from b in context.Bookings
                       join br in context.BRBookingGuests on b.Id equals br.BookingId
                       join g in context.Guests on br.GuestId equals g.Id
                       join r in context.Rooms on b.RoomId equals r.Id
                       select new
                       {
                           CheckinDate = b.CheckinDate,
                           CheckoutDate = b.CheckoutDate,
                           RoomNumber = b.Room.RoomNumber,
                           TotalPrice = b.TotalPrice,
                           Guest = g.FirstName + g.LastName,
                           Phone = g.Phone,
                           OdaTipi = r.RoomType.Name
                       };
            }
        }

        private void GeriButonu_Click(object sender, EventArgs e)
        {
            MisafirBilgileriniKontrolEt();
            misafirSayaci -= 1;
            FillControls();
            if (İleriButonu.Enabled == false)
            {
                İleriButonu.Enabled = true;
            }
        }

        private void MisafirBilgileriniKontrolEt()
        {
            Guest guest = new Guest()
            {
                IdentityNumber = txtKimlikNo.Text,
                FirstName = txtAdi.Text,
                LastName = txtSoyadi.Text,
                Phone = txtTelefon.Text,
                Email = txtEmail.Text,
                Address = txtAdres.Text,
                DateOfBirth = DateOnly.FromDateTime(dtpDogumTarihi.Value)
            };
            misafirler[misafirSayaci] = guest;
        }

        private void İleriButonu_Click(object sender, EventArgs e)
        {
            MisafirBilgileriniKontrolEt();
            misafirSayaci += 1;
            if (misafirler[misafirSayaci] == null)
            {
                CleanControls();
            }
            else
            {
                FillControls();
            }

            if (kisiSayisi == misafirSayaci + 1)
            {
                btnKaydet.Enabled = true;
                İleriButonu.Enabled = false;
            }
        }

        private void CleanControls()
        {
            txtAdi.Clear();
            txtKimlikNo.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            dtpDogumTarihi.Value = DateTime.Now;

        }
        private void FillControls()
        {
            txtAdi.Text = misafirler[misafirSayaci].FirstName;
            txtSoyadi.Text = misafirler[misafirSayaci].LastName;
            txtAdres.Text = misafirler[misafirSayaci].Address;
            txtEmail.Text = misafirler[misafirSayaci].Email;
            txtTelefon.Text = misafirler[misafirSayaci].Phone;
            txtKimlikNo.Text = misafirler[misafirSayaci].IdentityNumber;
            dtpDogumTarihi.Value = misafirler[misafirSayaci].DateOfBirth.ToDateTime(TimeOnly.MinValue);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvRezervasyonlar.DataSource = FillReservations(Guid.Empty).ToList();
        }
    }
}