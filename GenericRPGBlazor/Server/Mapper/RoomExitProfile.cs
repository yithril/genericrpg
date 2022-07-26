using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class RoomExitProfile : Profile
    {
        public RoomExitProfile()
        {
            CreateMap<RoomExitDTO, RoomExit>().ReverseMap();
        }
    }
}
