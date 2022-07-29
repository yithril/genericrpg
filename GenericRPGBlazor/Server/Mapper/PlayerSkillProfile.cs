using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class PlayerSkillProfile : Profile
    {
        public PlayerSkillProfile()
        {
            CreateMap<PlayerSkillDTO, PlayerSkill>().ReverseMap();
        }
    }
}
