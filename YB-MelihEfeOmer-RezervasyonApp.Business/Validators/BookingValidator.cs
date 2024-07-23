﻿using FluentValidation;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Validators
{
    public class BookingValidator : AbstractValidator<Booking>
    {
        public BookingValidator()
        {
            RuleFor(b => b.CheckinDate).NotEmpty().WithMessage("Giriş tarihi boş bırakılamaz.");

            RuleFor(b => b.CheckoutDate).NotEmpty().WithMessage("Çıkış tarihi boş bırakılamaz.");

            RuleFor(b => b).Must(b => b.CheckoutDate == default(DateOnly) || b.CheckinDate == default(DateOnly) || b.CheckoutDate > b.CheckinDate)
        .WithMessage("EndTime must greater than StartTime");

            RuleFor(b => b.TotalPrice).GreaterThanOrEqualTo(0).WithMessage("Toplam tutar negatif bir sayı olamaz.");
        }
    }
}
