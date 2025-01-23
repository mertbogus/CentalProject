using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.BrandsDtos
{
    public  class UpdateBrandDto
    {
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
    }
}
