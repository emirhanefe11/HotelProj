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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestomonialDal _testomonialDal;

        public TestimonialManager(ITestomonialDal testomonialDal)
        {
            _testomonialDal = testomonialDal;
        }

        public void TDelete(Testimonial T)
        {
           _testomonialDal.Delete(T);
        }

        public List<Testimonial> TGetAll()
        {
            return _testomonialDal.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testomonialDal.GetById(id);
        }

        public void TInsert(Testimonial T)
        {
           _testomonialDal.Insert(T);
        }

        public void TUpdate(Testimonial T)
        {
           _testomonialDal.Update(T);
        }
    }
}
