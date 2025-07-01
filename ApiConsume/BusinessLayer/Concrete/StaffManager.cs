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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }
        public void TDelete(Staff T)
        {
           _staffDal.Delete(T);
        }

        public List<Staff> TGetAll()
        {
          return _staffDal.GetAll();
        }

        public Staff TGetById(int id)
        {
          return _staffDal.GetById(id);
        }

        public void TInsert(Staff T)
        {
           _staffDal.Insert(T);
        }

        public void TUpdate(Staff T)
        {
            _staffDal.Update(T);
        }
    }
}
