using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class LimbProfile : Profile
    {
        public LimbProfile()
        {
            CreateMap<LimbDTO, Limb>().ReverseMap();
        }
    }
}
