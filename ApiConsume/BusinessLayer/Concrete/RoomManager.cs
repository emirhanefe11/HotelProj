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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            this._roomDal = roomDal;
        }
        public void TDelete(Room T)
        {
            _roomDal.Delete(T);
        }

        public List<Room> TGetAll()
        {
            return _roomDal.GetAll();
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public void TInsert(Room T)
        {
           _roomDal.Insert(T);
        }

        public void TUpdate(Room T)
        {
           _roomDal.Update(T);
        }
    }
}
