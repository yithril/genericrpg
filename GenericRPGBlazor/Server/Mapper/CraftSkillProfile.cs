using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class CraftSkillProfile : Profile
    {
        public CraftSkillProfile()
        {
            CreateMap<CraftSkillDTO, CraftSkill>().ReverseMap();
        }
    }
}
