using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class RoomItemProfile : Profile
    {
        public RoomItemProfile()
        {
            CreateMap<RoomItemDTO, RoomItem>().ReverseMap();
        }
    }
}
