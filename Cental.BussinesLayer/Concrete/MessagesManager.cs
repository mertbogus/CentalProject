using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DtoLayer.MessageDtos;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class MessagesManager : IMessagesService
    {
        private readonly IMessagesDal _messagesDal;

        public MessagesManager(IMessagesDal messagesDal)
        {
            _messagesDal = messagesDal;
        }

        public void TCreate(Message entity)
        {
           _messagesDal.Create(entity);
        }


        public void TDelete(int id)
        {
           _messagesDal.Delete(id);
        }

        public List<Message> TGetAll()
        {
            return _messagesDal.GetAll();
        }

        public Message TGetById(int id)
        {
            return _messagesDal.GetById(id);
        }

        public void TUpdate(Message entity)
        {
            _messagesDal.Update(entity);
        }
    }
}
