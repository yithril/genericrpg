using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<RoomDTO, Room>().ReverseMap();
        }
    }
}
