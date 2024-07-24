using FluentValidation;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Validators
{
    public class GuestValidator : AbstractValidator<Guest>
    {
        public GuestValidator()
        {
            RuleFor(g => g.IdentityNumber).Length(11).WithMessage("Kimlik numarası 11 rakamdan oluşmalıdır.")
                .Matches("^\\d+$").WithMessage("Kimlik numarası sadece rakamlardan oluşmalıdır.")
                .NotEmpty().WithMessage("Kimlik numarası alanı boş bırakılamaz.");

            RuleFor(g => g.FirstName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.")
                .Length(2, 50).WithMessage("Ad alanı en az 2 karakter uzunluğunda olmalıdır.")
                .Matches(@"[\p{L} ]+$").WithMessage("Ad alanı sayı veya noktalama işareti içeremez.");
            
            RuleFor(g => g.LastName).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.")
                .Length(2, 50).WithMessage("Soyad alanı en az 2 karakterli olmalıdır.")
                .Matches(@"[\p{L} ]+$").WithMessage("Soyad alanı sayı veya noktalama işareti içeremez.");

            RuleFor(g => g.DateOfBirth).NotEmpty().WithMessage("Doğum tarihi alanı boş bırakılamaz.")
                .Must(g => g < DateOnly.FromDateTime(DateTime.Now)).WithMessage("Doğum tarihi bugün seçilemez.");

            RuleFor(g => g.Address).NotEmpty().WithMessage("Adres alanı boş bırakılamaz.")
                .Length(25, 255).WithMessage("Adres alanı 25 ile 255 karakter arasında olmalıdır.");

            RuleFor(g => g.Phone).NotEmpty().WithMessage("Telefon alanı boş bırakılamaz.")
                .Length(3, 15).WithMessage("Telefon numarası 3 ile 15 karakter arasında olmalıdır.")
                .Matches("^\\d+$").WithMessage("Telefon numarası sadece rakamlardan oluşmalıdır.");

            RuleFor(g => g.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.")
                .EmailAddress().WithMessage("Email adresi geçersiz.");
        }
    }
}
