using AutoMapper;
using GenericRPGBlazor.Server.Data;
using GenericRPGBlazor.Server.Services.Interface;

namespace GenericRPGBlazor.Server.Services
{
    public class ItemService : IItemService
    {
        private readonly GameDbContext _context;
        private readonly IMapper _mapper;

        public ItemService(GameDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
