using HotelProject.Web.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Web.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]

        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {

            createBookingDto.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jsonData =JsonConvert.SerializeObject(createBookingDto);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("http://localhost:29309/api/Booking", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");

            }
            return View();
        }
    }
}
