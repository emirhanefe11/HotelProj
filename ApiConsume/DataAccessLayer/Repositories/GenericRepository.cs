using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly Context _context;

        public GenericRepository(Context context)
        {
            this._context = context;
        }
        public void Delete(T T)
        {
            _context.Remove(T);
            _context.SaveChanges();

        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public void Insert(T T)
        {
           _context.Add(T);
            _context.SaveChanges();
        }

        public void Update(T T)
        {
            _context.Update(T);
            _context.SaveChanges();
        }
    }
}
