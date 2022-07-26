using AutoMapper;
using GenericRPGBlazor.Server.Data;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace GenericRPGBlazor.Server.Services
{
    public class RoomService : IRoomService
    {
        private GameDbContext _context;
        private IMapper _mapper;

        public RoomService(GameDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);

            if(room == null)
            {
                return false;
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<RoomDTO> CreateRoom(RoomDTO dtoRoom)
        {
            var room = _mapper.Map<Room>(dtoRoom);

            _context.Rooms.Add(room);

            await _context.SaveChangesAsync();

            return (dtoRoom);
        }

        public async Task<RoomDTO> GetRoomById(int id)
        {
            var room = await _context.Rooms.Where(x => x.Id == id)
                         .Include(y => y.ExitList)
                         .Include(y => y.RoomItems)
                         .ThenInclude(x => x.Item)
                         .Include(y => y.NPCs)
                         .ThenInclude(x => x.NPC)
                         .FirstOrDefaultAsync();

            if(room == null)
            {
                return new RoomDTO();
            }

            var dto = _mapper.Map<RoomDTO>(room);

            //handle items
            dto.Items = _mapper.Map<List<ItemDTO>>(room.RoomItems.Select(y => y.Item).ToList());

            //handle npcs
            dto.NPCs = _mapper.Map<List<NPCDTO>>(room.NPCs.Select(y => y.NPC).ToList());

            return dto;
        }
    }
}
