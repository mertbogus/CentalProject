using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Validators.BrandValidators
{
    public class CreateBrandValidator : AbstractValidator<Brand>
    {
        public CreateBrandValidator()
        {

            RuleFor(x => x.BrandName).NotEmpty().WithMessage("Marka İsmini Boş Bırakamazsınız.")
                .MinimumLength(3).WithMessage("Marka İsmi En Az 3 Karakter Olmalıdır.");
        }
    }
}
