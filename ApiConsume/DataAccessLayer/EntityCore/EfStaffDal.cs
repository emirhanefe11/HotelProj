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
    public class EfStaffDal : GenericRepository<Staff>,IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {

        }
    }
}
