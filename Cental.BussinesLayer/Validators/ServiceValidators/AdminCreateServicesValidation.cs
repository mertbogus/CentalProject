using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Validators.ServiceValidators
{
    public class AdminCreateServicesValidation : AbstractValidator<Service>
    {
        public AdminCreateServicesValidation() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Kısmını Boş Bırakamazsınız.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Feature Açıklama Kısmını Kısmını Boş Bırakamazsınız.");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İcon Kısmını Kısmını Boş Bırakamazsınız.");
        }
    }
}
