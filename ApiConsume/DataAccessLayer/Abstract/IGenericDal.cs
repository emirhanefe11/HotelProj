﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T T);

        void Delete(T T);

        void Update(T T);

        List<T> GetAll();

        T GetById(int id);
    }
}
