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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _BookingDal;
        public BookingManager(IBookingDal BookingDal)
        {
            this._BookingDal = BookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
          _BookingDal.BookingStatusChangeApproved(booking);
        }

        public void TDelete(Booking T)
        {
            _BookingDal.Delete(T);
        }

        public List<Booking> TGetAll()
        {
            return _BookingDal.GetAll();
        }

        public Booking TGetById(int id)
        {
            return _BookingDal.GetById(id);
        }

        public void TInsert(Booking T)
        {
            _BookingDal.Insert(T);
        }

        public void TUpdate(Booking T)
        {
            _BookingDal.Update(T);
        }
    }
}
