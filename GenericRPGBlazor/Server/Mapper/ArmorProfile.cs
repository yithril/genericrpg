using AutoMapper;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.Mapper
{
    public class ArmorProfile : Profile
    {
        public ArmorProfile()
        {
            CreateMap<ArmorDTO, Armor>().ReverseMap();
        }
    }
}
