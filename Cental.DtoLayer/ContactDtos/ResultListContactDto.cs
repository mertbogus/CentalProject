using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.ContactDtos
{
    public class ResultListContactDto
    {
        public int ContactId { get; set; }

        public string Address { get; set; }

        public string Mail { get; set; }
        public string Telephone { get; set; }

        public string? AboutUs { get; set; }
        public string? OpeningHours { get; set; }
    }
}
