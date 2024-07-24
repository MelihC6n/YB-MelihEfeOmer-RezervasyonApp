using FluentValidation;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Validators
{
    public class BookingValidator : AbstractValidator<Booking>
    {
        public BookingValidator()
        {
            RuleFor(b => b.CheckinDate).NotEmpty().WithMessage("Giriş tarihi boş bırakılamaz.\n");

            RuleFor(b => b.CheckoutDate).NotEmpty().WithMessage("Çıkış tarihi boş bırakılamaz.\n");

            RuleFor(b => b).Must(b => b.CheckoutDate >= b.CheckinDate)
        .WithMessage("Çıkış tarihi giriş tarihinden önce olamaz.\n");

            RuleFor(b => b.TotalPrice).GreaterThanOrEqualTo(0).WithMessage("Toplam tutar negatif bir sayı olamaz.\n");
        }
    }
}
