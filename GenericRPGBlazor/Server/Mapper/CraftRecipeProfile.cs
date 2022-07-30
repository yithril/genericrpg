using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class CraftRecipeProfile: Profile
    {
        public CraftRecipeProfile()
        {
            CreateMap<CraftRecipeDTO, CraftRecipe>().ReverseMap();
        }
    }
}
