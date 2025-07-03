using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;

        public SubscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public ActionResult SubscribeList()
        {

            var values = _SubscribeService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddSubscribe(Subscribe Subscribe)
        {

            _SubscribeService.TInsert(Subscribe);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteSubscribe(int id)
        {
            var values = _SubscribeService.TGetById(id);
            _SubscribeService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TUpdate(Subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetSubscribe(int id)
        {
            var values = _SubscribeService.TGetById(id);
            return Ok(values);
        }

    }
}
