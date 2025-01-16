using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Process : BaseEntity
    {
        public int ProcessId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
