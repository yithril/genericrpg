using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class GameZoneProfile : Profile
    {
        public GameZoneProfile()
        {
            CreateMap<GameZoneDTO, GameZone>().ReverseMap();
        }
    }
}
