using Cental.DtoLayer.BookingDtos;
using Cental.DtoLayer.ReviewDtos;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Abstract
{
    public  interface IReviewService : IGenericService<Review>
    {
        List<ResultReviewDto> TGetReviewsUserById(int userId);
    }
}
