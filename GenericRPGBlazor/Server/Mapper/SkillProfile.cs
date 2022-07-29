using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<SkillDTO, Skill>().ReverseMap();
        }
    }
}
