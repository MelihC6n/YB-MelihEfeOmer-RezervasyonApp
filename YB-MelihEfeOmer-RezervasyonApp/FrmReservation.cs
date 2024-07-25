using FluentValidation.Results;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YB_MelihEfeOmer_RezervasyonApp.Business.Services;
using YB_MelihEfeOmer_RezervasyonApp.Business.Validators;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Abstract;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace YB_MelihEfeOmer_RezervasyonApp
{
    public partial class FrmReservation : Form
    {
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
            dtpGirisTarihi.MinDate = DateTime.Now;
            dtpCikisTarihi.MinDate = DateTime.Now.AddDays(1);
            dtpDogumTarihi.MaxDate = DateTime.Now.AddDays(-1);
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
        Room selectedRoom;
        decimal totalPrice;

        private void btnOdaBul_Click(object sender, EventArgs e)
        {
            grpRooms.Enabled = false;

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
                                     OdaTipi = r.RoomType,
                                     PricePerNight = r.RoomType.PricePerNight,
                                     RoomTypeName = r.RoomType.Name
                                 };
            //dataGridView1.DataSource = avaliableRooms.ToList();
            var freeBookings = from b in context.Bookings
                               where b.CheckinDate <= DateOnly.FromDateTime(dtpCikisTarihi.Value) && b.CheckoutDate >= DateOnly.FromDateTime(dtpGirisTarihi.Value) && b.IsDeleted == false
                               select b;

            List<Guid> freeBookingIds = freeBookings.Select(b => b.Room.Id).ToList();


            avaliableBooking = avaliableRooms.Where(r => !freeBookingIds.Contains(r.Id)).ToList();

            //var canSelectRoom = avaliableBookings.Where(r => r.OdaTipi == cmbOdaTipi.SelectedText);
            /*cmbOda.DataSource = avaliableBookings;
            cmbOda.DisplayMember = "RoomNumber";
            cmbOda.ValueMember = "Id";*/

            if (avaliableBooking.Count == 0)
            {
                cmbOdaTipi.SelectedItem = null;
                cmbOda.SelectedItem = null;
                MessageBox.Show("Aradığınız kriterlere göre bu tarihte uygun oda bulunmamakta. Lütfen farklı tarih seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                grpRooms.Enabled = true;
                cmbOdaTipi.DataSource = null;
                cmbOdaTipi.DisplayMember = "DisplayInfo";
                cmbOdaTipi.ValueMember = "OdaTipiId";
                cmbOdaTipi.DataSource = avaliableBooking.GroupBy(x => new { x.OdaTipi.Name, x.OdaTipi.Id }).Select(x => new
                {
                    OdaTipi = x.Key.Name,
                    OdaTipiId = x.Key.Id,
                    DisplayInfo = $"{x.First().RoomTypeName} - {x.First().PricePerNight}:TL - {x.First().Capacity}",
                    Odalar = x.ToList()
                }).ToList();


            }

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
                İleriButonu.Enabled = true;
            }
        }

        private bool RezervasyonBilgileriniKontrolEt()
        {
            try
            {
                BookingValidator bVal = new BookingValidator();
                Booking checkbooking = new Booking();
                checkbooking.CheckinDate = DateOnly.FromDateTime(dtpGirisTarihi.Value);
                checkbooking.CheckoutDate = DateOnly.FromDateTime(dtpCikisTarihi.Value);
                checkbooking.TotalPrice = 0;
                ValidationResult result = bVal.Validate(checkbooking);
                if (!result.IsValid)
                {
                    throw new Exception(string.Join(", ", result.Errors));
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                grpRooms.Enabled = false;
                return false;
            }
        }

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdaTipi.SelectedValue != null)
            {
                cmbOda.DisplayMember = "RoomNumber";
                cmbOda.ValueMember = "Id";
                cmbOda.DataSource = avaliableBooking.Where(ab => (Guid)ab.OdaTipi.Id == (Guid)cmbOdaTipi.SelectedValue).ToList();

                lblToplamTutar.Text = totalPrice.ToString();
            }
        }

        List<Guest> misafirler;
        int kisiSayisi;
        int misafirSayaci = 0;
        Guid lastBookingId;
        bool formStatus = true;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            bool isValid = MisafirBilgileriniKontrolEt();
            if (isValid)
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (formStatus)
                        {
                            Booking booking = new Booking()
                            {
                                CheckinDate = DateOnly.FromDateTime(dtpGirisTarihi.Value),
                                CheckoutDate = DateOnly.FromDateTime(dtpCikisTarihi.Value),
                                TotalPrice = totalPrice,
                                RoomId = selectedRoom.Id,
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
                                    BookingId = booking.Id,
                                    GuestId = guest.Id
                                };



                                BRBookingGuestService.Add(bRBookingGuest);
                            }
                            transaction.Commit();
                            lastBookingId = booking.Id;
                            MessageBox.Show(kisiSayisi + " Kişinin kaydı başarıyla gerçekleşti", "Misafir Bilgi Girişi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            _booking.CheckinDate = DateOnly.FromDateTime(dtpGirisTarihiGüncelleme.Value);
                            _booking.CheckoutDate = DateOnly.FromDateTime(dtpCikisTarihiGüncelleme.Value);
                            _booking.TotalPrice = totalPrice;
                            _booking.RoomId = selectedRoom.Id;

                            bookingService.Update(_booking);

                            foreach (var m in misafirler)
                            {
                                guestService.Update(m);
                            }
                            transaction.Commit();
                            lastBookingId = _booking.Id;
                            MessageBox.Show(kisiSayisi + " Kişinin güncellemesi başarıyla gerçekleşti", "Misafir Bilgi Güncellemesi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        FillDataGridWithReservations();
                        CleanControls();
                        grpPersonalDetails.Enabled = false;
                        grpReservationDetails.Enabled = true;
                        grpRooms.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
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
                       where b.Id == lastBookingId && b.IsDeleted == false
                       join br in context.BRBookingGuests on b.Id equals br.BookingId
                       join g in context.Guests on br.GuestId equals g.Id
                       join r in context.Rooms on b.RoomId equals r.Id
                       select new
                       {
                           RezId = b.Id,
                           CheckinDate = b.CheckinDate,
                           CheckoutDate = b.CheckoutDate,
                           RoomNumber = b.Room.RoomNumber,
                           TotalPrice = b.TotalPrice,
                           Guest = g.FirstName + " " + g.LastName,
                           Phone = g.Phone,
                           OdaTipi = r.RoomType.Name
                       };
            }
            else
            {
                return from b in context.Bookings
                       where b.IsDeleted == false
                       join br in context.BRBookingGuests on b.Id equals br.BookingId
                       join g in context.Guests on br.GuestId equals g.Id
                       join r in context.Rooms on b.RoomId equals r.Id
                       select new
                       {
                           RezId = b.Id,
                           CheckinDate = b.CheckinDate,
                           CheckoutDate = b.CheckoutDate,
                           RoomNumber = b.Room.RoomNumber,
                           TotalPrice = b.TotalPrice,
                           Guest = g.FirstName + " " + g.LastName,
                           Phone = g.Phone,
                           OdaTipi = r.RoomType.Name
                       };
            }
        }

        private void GeriButonu_Click(object sender, EventArgs e)
        {
            bool isValid = MisafirBilgileriniKontrolEt();
            if (isValid)
            {
                misafirSayaci -= 1;
                grpPersonalDetails.Text = $"{misafirSayaci + 1}. Misafirin Bilgilerini Giriniz";
                FillControls();
                MessageBox.Show(misafirler[misafirSayaci].Id.ToString());
                if (İleriButonu.Enabled == false)
                {
                    İleriButonu.Enabled = true;
                }
                if (misafirSayaci == 0)
                {
                    GeriButonu.Enabled = false;
                }
            }
        }
        
        private bool MisafirBilgileriniKontrolEt()
        {
            try
            {
                GuestValidator guestValidator = new();
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
                if (misafirler[misafirSayaci] != null)
                {
                    guest.Id = misafirler[misafirSayaci].Id;
                }


                ValidationResult result = guestValidator.Validate(guest);
                if (!result.IsValid)
                {
                    throw new Exception(string.Join("", result.Errors));
                }
                misafirler[misafirSayaci] = guest;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void İleriButonu_Click(object sender, EventArgs e)
        {
            bool isValid = MisafirBilgileriniKontrolEt();
            if (isValid)
            {
                MisafirBilgileriniKontrolEt();
                misafirSayaci += 1;
                grpPersonalDetails.Text = $"{misafirSayaci + 1}. Misafirin Bilgilerini Giriniz";
                if (misafirler[misafirSayaci] == null)
                {
                    CleanControls();
                }
                else
                {
                    MessageBox.Show(misafirler[misafirSayaci].Id.ToString());
                    FillControls();
                }
                if (kisiSayisi == misafirSayaci + 1)
                {
                    btnKaydet.Enabled = true;
                    İleriButonu.Enabled = false;
                }
                if (GeriButonu.Enabled == false)
                {
                    GeriButonu.Enabled = true;
                }
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
            dtpDogumTarihi.Value = DateTime.Now.AddHours(-25);

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
            if (btnListele.Text == "Güncellemeden Çık")
            {
                grpReservationDetails.BringToFront();
                grpReservationDetails.Enabled = true;
                dgvRezervasyonlar.DataSource = FillReservations(Guid.Empty).ToList();
                btnGüncelle.Enabled = true;
                btnListele.Text = "Listele";
                formStatus = true;
            }

        }
        Booking _booking;
        Guid _hotelId;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count == 1)
            {
                formStatus = false;
                grpGüncelleme.BringToFront();
                grpReservationDetails.Enabled = false;
                btnListele.Text = "Güncellemeden Çık";
                btnGüncelle.Enabled = false;
                grpOdaGüncelleme.Enabled = false;

                _booking = bookingService.GetById((Guid)dgvRezervasyonlar.CurrentRow.Cells["RezId"].Value);
                var currentRoom = roomService.GetById(_booking.RoomId);
                GüncellemeBilgileriniDoldur(_booking);


                //müşterileri getirme

                misafirler = context.BRBookingGuests.Where(br => br.BookingId == (Guid)dgvRezervasyonlar.CurrentRow.Cells["RezId"].Value).Select(br => br.Guest).ToList();
                misafirSayaci = 0;
                kisiSayisi = misafirler.Count;
                FillControls();
                grpPersonalDetails.Text = (misafirSayaci + 1) + ". Misafirin Bilgilerini Giriniz";

                //Oteli getirme
                _hotelId = currentRoom.HotelId;
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz rezervasyonu listeden seçiniz.");
            }

        }

        private void GüncellemeBilgileriniDoldur(Booking b)
        {
            dtpGirisTarihiGüncelleme.Value = DateTime.Parse(b.CheckinDate.ToString());
            dtpCikisTarihiGüncelleme.Value = DateTime.Parse(b.CheckoutDate.ToString());


        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpCikisTarihi.MinDate = dtpGirisTarihi.Value.AddDays(1);
            //if (!RezervasyonBilgileriniKontrolEt())
            //{
            //}

        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            //if (!RezervasyonBilgileriniKontrolEt())
            //{
            //    dtpCikisTarihi.Value = dtpGirisTarihi.Value.AddDays(1);
            //}
        }

        private void txtKimlikAra_TextChanged(object sender, EventArgs e)
        {
            string kimlikAra = txtKimlikAra.Text.ToLower();
            dgvRezervasyonlar.DataSource = null;

            if (!string.IsNullOrEmpty(kimlikAra) && kimlikAra.Length >= 3)
            {
                var tList = guestService.GetAll().Where(x => x.IdentityNumber.ToLower().Contains(kimlikAra));

                dgvRezervasyonlar.DataSource = tList.ToList();

            }
            else if (kimlikAra.Length == 0)
            {
                FillDataGridWithReservations();
            }
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            string AdAra = txtAdAra.Text.ToLower();
            dgvRezervasyonlar.DataSource = null;

            if (!string.IsNullOrEmpty(AdAra) && AdAra.Length >= 3)
            {
                var aList = guestService.GetAll().Where(x => x.FirstName.ToLower()
                .Contains(AdAra));

                dgvRezervasyonlar.DataSource = aList.ToList();
            }
            else if (AdAra.Length == 0)
            {
                FillDataGridWithReservations();
            }

        }

        private void txtRezAra_TextChanged(object sender, EventArgs e)
        {

            string rezAra = txtRezAra.Text.ToLower();
            dgvRezervasyonlar.DataSource = null;



            var filteredBridge = context.BRBookingGuests
    .Where(br => br.BookingId.ToString().Contains(rezAra))
    .Select(br => br.BookingId);

            var results = from b in context.Bookings
                          join brID in filteredBridge on b.Id equals brID
                          join br in context.BRBookingGuests on b.Id equals br.BookingId
                          join g in context.Guests on br.GuestId equals g.Id
                          join r in context.Rooms on b.RoomId equals r.Id
                          select new
                          {
                              RezId = b.Id,
                              CheckinDate = b.CheckinDate,
                              CheckoutDate = b.CheckoutDate,
                              RoomNumber = b.Room.RoomNumber,
                              TotalPrice = b.TotalPrice,
                              Guest = g.FirstName + " " + g.LastName,
                              Phone = g.Phone,
                              OdaTipi = r.RoomType.Name
                          };
            dgvRezervasyonlar.DataSource = results.ToList();
        }

        private void btnGüncellemeOdaBul_Click(object sender, EventArgs e)
        {
            grpOdaGüncelleme.Enabled = true;


            //var roomWithType = roomService.GetAllQueryable().Where(r=>r.HotelId==(Guid)cmbOtelAdi.SelectedValue);
            // dataGridView1.DataSource= roomWithType.ToList();
            var avaliableRooms = from r in context.Rooms
                                 where r.RoomType.Capacity >= misafirler.Count && r.HotelId == _hotelId
                                 select new avaliableBooking
                                 {
                                     HotelId = r.HotelId,
                                     Name = r.Hotel.Name,
                                     RoomNumber = r.RoomNumber,
                                     Capacity = (byte)r.RoomType.Capacity,
                                     Id = r.Id,
                                     OdaTipi = r.RoomType,
                                     PricePerNight = r.RoomType.PricePerNight,
                                     RoomTypeName = r.RoomType.Name
                                 };
            //dataGridView1.DataSource = avaliableRooms.ToList();
            var freeBookings = from b in context.Bookings
                               where b.CheckinDate <= DateOnly.FromDateTime(dtpCikisTarihiGüncelleme.Value) && b.CheckoutDate >= DateOnly.FromDateTime(dtpGirisTarihiGüncelleme.Value) && b.IsDeleted == false
                               select b;

            List<Guid> freeBookingIds = freeBookings.Select(b => b.Room.Id).ToList();


            avaliableBooking = avaliableRooms.Where(r => !freeBookingIds.Contains(r.Id)).ToList();

            //var canSelectRoom = avaliableBookings.Where(r => r.OdaTipi == cmbOdaTipi.SelectedText);
            /*cmbOda.DataSource = avaliableBookings;
            cmbOda.DisplayMember = "RoomNumber";
            cmbOda.ValueMember = "Id";*/

            if (avaliableBooking.Count == 0)
            {
                grpOdaGüncelleme.Enabled = false;
                cmbOdaTipiGüncelleme.SelectedItem = null;
                cmbOdaGüncelleme.SelectedItem = null;
                MessageBox.Show("Aradığınız kriterlere göre bu tarihte uygun oda bulunmamakta. Lütfen farklı tarih seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                grpRooms.Enabled = true;
                cmbOdaTipiGüncelleme.DataSource = null;
                cmbOdaTipiGüncelleme.DisplayMember = "DisplayInfo";
                cmbOdaTipiGüncelleme.ValueMember = "OdaTipiId";
                cmbOdaTipiGüncelleme.DataSource = avaliableBooking.GroupBy(x => new { x.OdaTipi.Name, x.OdaTipi.Id }).Select(x => new
                {
                    OdaTipi = x.Key.Name,
                    OdaTipiId = x.Key.Id,
                    DisplayInfo = $"{x.First().RoomTypeName} - {x.First().PricePerNight}:TL - {x.First().Capacity}",
                    Odalar = x.ToList()
                }).ToList();
            }
        }

        private void btnGüncellemeRezervasyonaBasla_Click(object sender, EventArgs e)
        {
            grpPersonalDetails.Enabled = true;
            if (kisiSayisi > 1)
            {
                İleriButonu.Enabled = true;
            }
            grpGüncelleme.Enabled = false;
        }



        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dgvRezervasyonlar.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Guid deletedItem = (Guid)dgvRezervasyonlar.CurrentRow.Cells["RezId"].Value;
                    bookingService.BookingDelete(deletedItem);

                    dgvRezervasyonlar.DataSource = FillReservations(Guid.Empty).ToList();


                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbOdaTipiGüncelleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdaTipiGüncelleme.SelectedValue != null)
            {
                cmbOdaGüncelleme.DisplayMember = "RoomNumber";
                cmbOdaGüncelleme.ValueMember = "Id";
                cmbOdaGüncelleme.DataSource = avaliableBooking.Where(ab => (Guid)ab.OdaTipi.Id == (Guid)cmbOdaTipiGüncelleme.SelectedValue).ToList();

                lblToplamTutar.Text = totalPrice.ToString();
            }
        }

        private void cmbOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOda.SelectedIndex != -1)
            {
                selectedRoom = roomService.GetById((Guid)cmbOda.SelectedValue);
                TimeSpan dayCount = dtpCikisTarihi.Value - dtpGirisTarihi.Value;
                totalPrice = dayCount.Days * selectedRoom.RoomType.PricePerNight;
            }
        }

        private void cmbOdaGüncelleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdaGüncelleme.SelectedIndex != -1)
            {
                selectedRoom = roomService.GetById((Guid)cmbOdaGüncelleme.SelectedValue);
                TimeSpan dayCount = dtpCikisTarihiGüncelleme.Value - dtpGirisTarihiGüncelleme.Value;
                totalPrice = dayCount.Days * selectedRoom.RoomType.PricePerNight;
            }
        }
    }
}
