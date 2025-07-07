using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;

        public BookingController(IBookingService BookingService)
        {
            _BookingService = BookingService;
        }

        [HttpGet]
        public ActionResult BookingList()
        {

            var values = _BookingService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddBooking(Booking Booking)
        {

            _BookingService.TInsert(Booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBooking(int id)
        {
            var values = _BookingService.TGetById(id);
            _BookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public ActionResult UpdateBooking(Booking Booking)
        {
            _BookingService.TUpdate(Booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetBooking(int id)
        {
            var values = _BookingService.TGetById(id);
            return Ok(values);
        }
        [HttpPut("aaaaa")]
        public IActionResult aaaaa(Booking booking)
        {
 _BookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
    }
}
