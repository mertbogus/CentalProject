using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Feature : BaseEntity
    {
        public int FeatureId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
