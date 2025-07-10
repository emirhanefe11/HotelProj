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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _IcontactDal;

        public ContactManager(IContactDal ıcontactDal)
        {
            _IcontactDal = ıcontactDal;
        }

        public void TDelete(Contact T)
        {
            _IcontactDal.Delete(T);
        }

        public List<Contact> TGetAll()
        {
           return _IcontactDal.GetAll();
        }

        public Contact TGetById(int id)
        {
           return _IcontactDal.GetById(id);
        }

        public void TInsert(Contact T)
        {
           _IcontactDal.Insert(T);
        }

        public void TUpdate(Contact T)
        {
            _IcontactDal.Update(T);
        }
    }
}
