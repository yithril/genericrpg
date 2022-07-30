using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class GameHelpProfile : Profile
    {
        public GameHelpProfile()
        {
            CreateMap<GameHelpDTO, GameHelp>().ReverseMap();
        }
    }
}
