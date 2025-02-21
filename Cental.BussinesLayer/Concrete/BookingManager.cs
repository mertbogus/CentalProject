using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;
        private readonly IMapper _mapper;

        public BookingManager(IBookingDal bookingDal, IMapper mapper)
        {
            _bookingDal = bookingDal;
            _mapper = mapper;
        }

        public void TCreate(Booking entity)
        {
            _bookingDal.Create(entity);
        }

        public void TDelete(int id)
        {
           _bookingDal.Delete(id);
        }

        public List<Booking> TGetAll()
        {
            return _bookingDal.GetAll();
        }

        public List<ResultUserBookingListDto> TGetBookingUserById(int userId)
        {
            var values = _bookingDal.TGetBookingByUserId(userId);
            return _mapper.Map<List<ResultUserBookingListDto>>(values);
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
