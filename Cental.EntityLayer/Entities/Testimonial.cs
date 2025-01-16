using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Testimonial : BaseEntity
    {
        public int TestimonialId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Review { get; set; }
        public string Comment { get; set; }
    }
}
