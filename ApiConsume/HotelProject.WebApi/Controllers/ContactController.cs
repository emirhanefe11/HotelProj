using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public ActionResult contactList()
        {

            var values = _contactService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult Addcontact(Contact contact)
        {
            contact.Date=Convert.ToDateTime(DateTime.Now);
            _contactService.TInsert(contact);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Deletecontact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public ActionResult Updatecontact(Contact contact)
        {
            _contactService.TUpdate(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult Getcontact(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
    }
}
