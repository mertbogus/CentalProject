using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Validators.CarValidation
{
    public class CreateCarValidation : AbstractValidator<Car>
    {
        public CreateCarValidation()
        {
            RuleFor(x => x.ModelName).NotEmpty().WithMessage("Araba Modelini Boş Bırakamazsınız.");
            RuleFor(x => x.Transmission).NotEmpty().WithMessage("Vites Türünü Boş Bırakamazsınız.");
            RuleFor(x => x.GasType).NotEmpty().WithMessage("Yakıt Türünü Boş Bırakamazsınız.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Bilgisini Boş Bırakamazsınız.");
            RuleFor(x => x.Kilometer).NotEmpty().WithMessage("Km Bilgisini Boş Bırakamazsınız.");
            RuleFor(x => x.Kilometer).NotEmpty().WithMessage("Vites Bilgisini Boş Bırakamazsınız.");
            RuleFor(x => x.SeatCout).NotEmpty().WithMessage("Koltuk Sayısını Boş Bırakamasınız.");
        }
    }
}
