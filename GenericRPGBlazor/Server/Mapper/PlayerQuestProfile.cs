using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class PlayerQuestProfile : Profile
    {
        public PlayerQuestProfile()
        {
            CreateMap<PlayerQuestDTO, PlayerQuest>().ReverseMap();
        }
    }
}
