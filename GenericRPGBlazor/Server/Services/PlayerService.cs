using AutoMapper;
using GenericRPGBlazor.Server.Data;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace GenericRPGBlazor.Server.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly GameDbContext _context;
        private readonly IMapper _mapper;

        public PlayerService(GameDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PlayerDTO>> GetAllPlayers(string authId)
        {
            var players = await _context.Players.Where(x => x.AuthId == authId).ToListAsync();

            var dto = _mapper.Map<List<PlayerDTO>>(players);

            return dto;
        }

        public async Task<PlayerDTO> GetPlayerById(int id)
        {
            var player = await _context.Players.SingleOrDefaultAsync(x => x.Id == id);

            if(player == null)
            {
                return new PlayerDTO();
            }

            var dto = _mapper.Map<PlayerDTO>(player);

            return dto;
        }

        //TO DO
        public async Task<bool> UpdatePlayer(int id, PlayerDTO update)
        {
            var player = _context.Players.SingleOrDefault(x => x.Id == id);

            if(player == null)
            {
                return false;
            }

            player.Xp = update.Xp;
            player.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);

            if(player == null)
            {
                return false;
            }

            try
            {
                player.IsActive = false;
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<PlayerDTO> CreatePlayer(PlayerDTO playerDTO, string authId)
        {
            var player = _mapper.Map<Player>(playerDTO);

            player.AuthId = authId;
            player.CreatedDate = DateTime.UtcNow;
            player.Xp = 0;

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return playerDTO;
        }
    }
}
