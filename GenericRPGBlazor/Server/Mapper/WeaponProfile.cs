using AutoMapper;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Mapper
{
    public class WeaponProfile : Profile
    {
        public WeaponProfile()
        {
            CreateMap<WeaponDTO, Weapon>().ReverseMap();
        }
    }
}
