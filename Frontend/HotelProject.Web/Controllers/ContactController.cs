using HotelProject.Web.Dtos.BookingDto;
using HotelProject.Web.Dtos.ContactDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]

        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {

            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:29309/api/Contact", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");

            }
            return View();
        }
    }
}
