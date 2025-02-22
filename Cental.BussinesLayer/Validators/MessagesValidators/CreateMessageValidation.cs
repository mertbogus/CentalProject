using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Validators.MessagesValidators
{
    public class CreateMessageValidation : AbstractValidator<Message>
    {
        public CreateMessageValidation()
        {

            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Kısmını Boş Bırakamazsınız.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Mail Kısmını Boş Bırakamazsınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Bırakamazsınız.");
            RuleFor(x => x.NameandSurName).NotEmpty().WithMessage("Adınızı ve Soyadınızı Boş Bırakamazsınız.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj Kısmını Boş Bırakamazsınız.");
        }
    }
}
