﻿using AutoMapper;
using DtoLayer.Dtos.RoomDto;
using EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto,Room>().ReverseMap();
        }
    }
}
