using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Brand : BaseEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual List<Car> Cars { get; set; }
    }
}
