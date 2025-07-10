using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Contact
{
    public class _ContactCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
