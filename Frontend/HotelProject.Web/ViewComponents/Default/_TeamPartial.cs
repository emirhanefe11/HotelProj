﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
