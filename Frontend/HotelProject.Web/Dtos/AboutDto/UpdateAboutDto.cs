﻿using System;

namespace HotelProject.Web.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }
        public String Title1 { get; set; }
        public String Title2 { get; set; }
        public String Content { get; set; }

        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
