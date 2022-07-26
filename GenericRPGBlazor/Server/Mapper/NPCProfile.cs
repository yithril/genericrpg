using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class NPCProfile : Profile
    {
        public NPCProfile()
        {
            CreateMap<NPCDTO, NPC>().ReverseMap();
        }
    }
}
