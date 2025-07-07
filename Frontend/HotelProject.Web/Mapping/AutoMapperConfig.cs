using AutoMapper;
using EntityLayer.Concrete;
using HotelProject.Web.Dtos.AboutDto;
using HotelProject.Web.Dtos.BookingDto;
using HotelProject.Web.Dtos.LoginDto;
using HotelProject.Web.Dtos.RegisterDto;
using HotelProject.Web.Dtos.RoomDto;
using HotelProject.Web.Dtos.ServiceDto;
using HotelProject.Web.Dtos.StaffDto;
using HotelProject.Web.Dtos.SubscribeDto;
using HotelProject.Web.Dtos.TestimonialDto;

namespace HotelProject.Web.Mapping
{
    public class AutoMapperConfig :Profile
    {

        public AutoMapperConfig() {
        
            CreateMap<ResultServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto,Service>().ReverseMap();
            CreateMap<CreateServiceDto,Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
          
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();
            
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            
            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
           
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();








        }
    }
}
