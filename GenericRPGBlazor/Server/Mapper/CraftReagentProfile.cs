using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class CraftReagentProfile : Profile
    {
        public CraftReagentProfile()
        {
            CreateMap<CraftReagentDTO, CraftReagent>().ReverseMap();
        }
    }
}
