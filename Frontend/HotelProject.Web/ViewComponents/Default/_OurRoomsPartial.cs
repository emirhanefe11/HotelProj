using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Default
{
    public class _OurRoomsPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
