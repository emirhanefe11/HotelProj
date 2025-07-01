using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public ActionResult ServiceList()
        {

            var values = _ServiceService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddService(Service Service)
        {

            _ServiceService.TInsert(Service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteService(int id)
        {
            var values = _ServiceService.TGetById(id);
            _ServiceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateService(Service Service)
        {
            _ServiceService.TUpdate(Service);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetService(int id)
        {
            var values = _ServiceService.TGetById(id);
            return Ok(values);
        }
    }
}
