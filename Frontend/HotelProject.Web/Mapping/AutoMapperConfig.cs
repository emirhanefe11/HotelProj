using AutoMapper;
using EntityLayer.Concrete;
using HotelProject.Web.Dtos.LoginDto;
using HotelProject.Web.Dtos.RegisterDto;
using HotelProject.Web.Dtos.ServiceDto;

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

        }
    }
}
