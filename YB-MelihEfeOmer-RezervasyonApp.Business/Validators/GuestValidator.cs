using FluentValidation;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Validators
{
    public class GuestValidator : AbstractValidator<Guest>
    {
        public GuestValidator()
        {
            RuleFor(g => g.IdentityNumber).Length(11).WithMessage("Kimlik numarası 11 rakamdan oluşmalıdır.\n")
                .Matches("^\\d+$").WithMessage("Kimlik numarası sadece rakamlardan oluşmalıdır.\n")
                .NotEmpty().WithMessage("Kimlik numarası alanı boş bırakılamaz.\n");

            RuleFor(g => g.FirstName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.\n")
                .Length(2, 50).WithMessage("Ad alanı en az 2 karakter uzunluğunda olmalıdır.\n")
                .Matches(@"[\p{L} ]+$").WithMessage("Ad alanı sayı veya noktalama işareti içeremez.\n");
            
            RuleFor(g => g.LastName).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.\n")
                .Length(2, 50).WithMessage("Soyad alanı en az 2 karakterli olmalıdır.\n")
                .Matches(@"[\p{L} ]+$").WithMessage("Soyad alanı sayı veya noktalama işareti içeremez.\n");

            RuleFor(g => g.DateOfBirth).NotEmpty().WithMessage("Doğum tarihi alanı boş bırakılamaz.\n")
                .Must(g => g < DateOnly.FromDateTime(DateTime.Now)).WithMessage("Doğum tarihi bugün seçilemez.\n");

            RuleFor(g => g.Address).NotEmpty().WithMessage("Adres alanı boş bırakılamaz.\n")
                .Length(5, 255).WithMessage("Adres alanı 5 ile 255 karakter arasında olmalıdır.\n");

            RuleFor(g => g.Phone).NotEmpty().WithMessage("Telefon alanı boş bırakılamaz.\n")
                .Length(3, 15).WithMessage("Telefon numarası 3 ile 15 karakter arasında olmalıdır.\n")
                .Matches("^\\d+$").WithMessage("Telefon numarası sadece rakamlardan oluşmalıdır.\n");

            RuleFor(g => g.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.\n")
                .EmailAddress().WithMessage("Email adresi geçersiz.\n");
        }
    }
}
