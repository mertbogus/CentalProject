using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.MessageDtos
{
    public class CreateMessageDto
    {
        public string Name { get; set; }
        public string Subject{ get; set; }
        public string MessageContent{ get; set; }
        public string Email{ get; set; }
    }
}
