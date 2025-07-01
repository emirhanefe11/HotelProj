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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void TDelete(Service T)
        {
            _serviceDal.Delete(T);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service TGetById(int id)
        {
           return _serviceDal.GetById(id);
        }

        public void TInsert(Service T)
        {
            _serviceDal.Insert(T);
        }

        public void TUpdate(Service T)
        {
           _serviceDal.Update(T);
        }
    }
}
