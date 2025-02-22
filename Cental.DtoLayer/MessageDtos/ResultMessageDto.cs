using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.MessageDtos
{
    public class ResultMessageDto
    {
        public int MessageId { get; set; }
        public string NameandSurName { get; set; }

        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public bool MessageStatus { get; set; }
    }
}
