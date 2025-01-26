using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.UserDtos
{
    public class UserRegisterDto 
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Şifreler Birbiri İle Aynı Değil.")]
        public string ConfirmPassword { get; set; }


    }
}
