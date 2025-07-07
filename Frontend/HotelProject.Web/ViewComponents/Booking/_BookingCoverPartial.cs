using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Booking
{
    public class _BookingCoverPartial : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
