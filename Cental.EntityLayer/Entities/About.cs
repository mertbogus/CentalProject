using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class About: BaseEntity
    {
        public int AboutId { get; set; }
        public string Vision { get; set; }
        public string Mission { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public int StartYear { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string NameSurname { get; set; }
        public string JobTitle { get; set; }
        public string ProfilePicture { get; set; }



    }
}
