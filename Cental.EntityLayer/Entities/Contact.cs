using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Contact : BaseEntity
    {
        public int ContactId { get; set; }

        public string Address { get; set; }

        public string Mail { get; set; }
        public string Telephone { get; set; }

        public string? AboutUs { get; set; }
        public string? OpeningHours { get; set; }


    }
}
