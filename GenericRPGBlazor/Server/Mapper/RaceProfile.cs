using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class RaceProfile : Profile
    {
        public RaceProfile()
        {
            CreateMap<RaceDTO, Race>().ReverseMap();
        }
    }
}
