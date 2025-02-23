using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DtoLayer.ReviewDtos;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDal _reviewDal;
        private readonly IMapper _mapper;

        public ReviewManager(IReviewDal reviewDal, IMapper mapper)
        {
            _reviewDal = reviewDal;
            _mapper = mapper;
        }

        public void TCreate(Review entity)
        {
            _reviewDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _reviewDal.Delete(id);
        }

        public List<Review> TGetAll()
        {
            return _reviewDal.GetAll();
        }

        public Review TGetById(int id)
        {
            return _reviewDal.GetById(id);
        }

        public List<ResultReviewDto> TGetReviewsUserById(int userId)
        {
            var values= _reviewDal.TGetReviewsUserById(userId);
            return _mapper.Map<List<ResultReviewDto>>(values);

        }

        public void TUpdate(Review entity)
        {
            _reviewDal.Update(entity);
        }
    }
}
