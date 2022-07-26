using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemDTO, Item>().ReverseMap();
        }
    }
}
