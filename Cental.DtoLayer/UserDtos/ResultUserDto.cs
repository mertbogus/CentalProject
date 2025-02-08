using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.UserDtos
{
    public class ResultUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName =>string.Join(" ",FirstName,LastName);

        public string ImageUrl { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public IList<string> Roles { get; set; }
    }
}
