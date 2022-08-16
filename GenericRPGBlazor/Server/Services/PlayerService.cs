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

        public async Task<bool> ValidatePlayerStart(int id, string authId)
        {
            //when someone connects, need to make sure that the person connecting is authoried to play this char
            return await _context.Players.AnyAsync(x => x.Id == id && x.AuthId == authId);
        }

        public async Task<List<PlayerDTO>> GetAllPlayers(string authId)
        {
            var dto = new List<PlayerDTO>();

            try
            {
                var players = await _context.Players.Where(x => x.AuthId == authId)
                    .Include(y => y.Race)
                    .Include(y => y.Skills)
                    .Include(y => y.Quests)
                    .Where(x => x.IsActive)
                    .ToListAsync();

                dto = _mapper.Map<List<PlayerDTO>>(players);
            }
            catch (Exception ex)
            {
                var blah = 5;
            }

            return dto;
        }

        public async Task<PlayerDTO> GetPlayerById(int id)
        {
            var player = await _context.Players
                .Include(y => y.Race)
                .Include(y => y.Skills)
                .Include(y => y.Quests)
                .SingleOrDefaultAsync(x => x.Id == id);

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
            await OnboardPlayer(playerDTO, authId);

            return playerDTO;
        }

        private async Task OnboardPlayer(PlayerDTO dto, string authId)
        {
            var player = _mapper.Map<Player>(dto);

            player.CreatedDate = DateTime.UtcNow;
            player.AuthId = authId;

            var race = await _context.Races.FindAsync(dto.RaceId);

            var playerSkillList = new List<PlayerSkill>();

            //setup the player hp
            player.Hp = (int)(race.HPModifier * dto.Constitution * 1.5);

            var endurance = dto.Skills.FirstOrDefault(x => x.SkillName == "Endurance");
            var esoteria = dto.Skills.FirstOrDefault(x => x.SkillName == "Esoteria");

            if (endurance != null && endurance.CurrentLevel > 0)
            {
                player.Hp += (int)(endurance.CurrentLevel * .15);
            }

            //setup the player mana
            player.Mana = (int)(race.MPModifier * dto.Intelligence * 2);

            if (esoteria !=null && esoteria.CurrentLevel > 0)
            {
                player.Mana += (int)(esoteria.CurrentLevel * .15);
            }

            //save the player
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            //setup their skills
            foreach (var s in dto.Skills)
            {
                var p = new PlayerSkill()
                {
                    PlayerId = player.Id,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    SkillId = s.SkillId
                };

                _context.PlayerSkills.Add(p);
            }

            //save
            await _context.SaveChangesAsync();
        }
    }
}
