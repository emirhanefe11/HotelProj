using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {

            private readonly ITestimonialService _TestimonialService;

            public TestimonialController(ITestimonialService TestimonialService)
            {
                _TestimonialService = TestimonialService;
            }

            [HttpGet]
            public ActionResult TestimonialList()
            {

                var values = _TestimonialService.TGetAll();
                return Ok(values);
            }
            [HttpPost]
            public ActionResult AddTestimonial(Testimonial Testimonial)
            {

                _TestimonialService.TInsert(Testimonial);
                return Ok();
            }
            [HttpDelete("{id}")]
            public ActionResult DeleteTestimonial(int id)
            {
                var values = _TestimonialService.TGetById(id);
                _TestimonialService.TDelete(values);
                return Ok();
            }
            [HttpPut]
            public ActionResult UpdateTestimonial(Testimonial Testimonial)
            {
                _TestimonialService.TUpdate(Testimonial);
                return Ok();
            }
            [HttpGet("{id}")]
            public ActionResult GetTestimonial(int id)
            {
                var values = _TestimonialService.TGetById(id);
                return Ok(values);
            }


        }
    }



