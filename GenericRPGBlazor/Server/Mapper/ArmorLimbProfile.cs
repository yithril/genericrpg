using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class ArmorLimbProfile : Profile
    {
        public ArmorLimbProfile()
        {
            CreateMap<ArmorLimbDTO, ArmorLimb>().ReverseMap();
        }
    }
}
