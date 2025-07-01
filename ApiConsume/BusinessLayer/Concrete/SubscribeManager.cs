using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subcribeDal;
        public SubscribeManager(ISubscribeDal subcribeDal)
        {
            _subcribeDal = subcribeDal;
        }

        public void TDelete(Subscribe T)
        {
            _subcribeDal.Delete(T);
        }

        public List<Subscribe> TGetAll()
        {
           return _subcribeDal.GetAll();
        }

        public Subscribe TGetById(int id)
        {
            return _subcribeDal.GetById(id);
        }

        public void TInsert(Subscribe T)
        {
           _subcribeDal.Insert(T);
        }

        public void TUpdate(Subscribe T)
        {
            _subcribeDal.Update(T);
        }
    }
}
