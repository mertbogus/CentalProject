using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class UserSocial : BaseEntity
    {
        public int UserSocialId { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public virtual AppUser User { get; set; }
    }
}
