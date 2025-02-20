using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.BookingDtos
{
    public  class ResultBookingDto
    {
        public int BookingId { get; set; }
        public string BookingPickUp { get; set; }
        public string BookingDropOf { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingLastDate { get; set; }
        public string BookingStatus { get; set; }

        public int CarId { get; set; }

        public int UserId { get; set; }

        public virtual AppUser User { get; set; }

        public virtual Car Cars { get; set; }
    }
}
