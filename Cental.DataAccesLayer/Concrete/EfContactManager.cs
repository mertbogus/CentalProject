﻿using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repositories;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Concrete
{
    public class EfContactManager : GenericRepository<Contact>, IContactDal
    {
        public EfContactManager(CentalContext context) : base(context)
        {
        }
    }
}
