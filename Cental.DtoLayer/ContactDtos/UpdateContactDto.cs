using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }

        public string Address { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }

        public string? SocialMediaUrl { get; set; }
        public string? SocialMediaİcon { get; set; }

        public string? AboutUs { get; set; }
        public TimeSpan? OpeningHours { get; set; }
    }
}
