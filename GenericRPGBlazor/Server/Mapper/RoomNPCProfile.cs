using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class RoomNPCProfile : Profile
    {
        public RoomNPCProfile()
        {
            CreateMap<RoomNPCDTO, RoomNPC>().ReverseMap();
        }
    }
}
