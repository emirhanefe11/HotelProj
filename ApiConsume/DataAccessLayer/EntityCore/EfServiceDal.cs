﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityCore
{
    public class EfServiceDal :GenericRepository<Service>,IServiceDal
    {
        public EfServiceDal(Context context) : base(context) {
        
        }
    }
}
