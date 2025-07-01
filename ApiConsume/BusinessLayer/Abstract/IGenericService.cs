using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {

        void TInsert(T T);

        void TDelete(T T);

        void TUpdate(T T);

        List<T> TGetAll();

        T TGetById(int id);
    }
}
