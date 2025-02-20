using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Validators.ProcessValidators
{
    public class AdminProcessValidation : AbstractValidator<Process>
    {
        public AdminProcessValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Kısmını Boş Bırakamazsınız.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Feature Açıklama Kısmını Kısmını Boş Bırakamazsınız.");
        }
    }
}
