using AutoMapper;
using GenericRPGBlazor.Server.Data;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace GenericRPGBlazor.Server.Services
{
    public class RaceService : IRaceService
    {
        private GameDbContext _gameDbContext;
        private readonly IMapper _mapper;

        public RaceService(GameDbContext gameDbContext, IMapper mapper)
        {
            _gameDbContext = gameDbContext;
            _mapper = mapper;
        }

        public async Task<List<RaceDTO>> GetRaces()
        {
            var races = await _gameDbContext.Races.ToListAsync();

            return _mapper.Map<List<RaceDTO>>(races);
        } 

        public async Task<RaceDTO> GetRaceById(int id)
        {
            var race = await _gameDbContext.Rooms.FindAsync(id);

            return _mapper.Map<RaceDTO>(race);
        }

        public async Task<List<RaceDTO>> GetPlayableRaces()
        {
            var races = await _gameDbContext.Races.Where(x => x.IsPlayable).ToListAsync();

            return _mapper.Map<List<RaceDTO>>(races);
        }

        public async Task<RaceDTO> CreateRace(RaceDTO raceDTO)
        {
            var race = _mapper.Map<Race>(raceDTO);

            race.CreatedDate = DateTime.UtcNow;
            race.IsActive = true;

            _gameDbContext.Races.Add(race);
            await _gameDbContext.SaveChangesAsync();

            return raceDTO;
        }

        public async Task<RaceDTO> UpdateRace(RaceDTO raceDTO)
        {
            var race = await _gameDbContext.Races.FindAsync(raceDTO.Id);

            if(race == null)
            {
                return new RaceDTO();
            }

            //TODO update the stuff

            race.ModifiedDate = DateTime.UtcNow;

            await _gameDbContext.SaveChangesAsync();

            return raceDTO;
        }

        public async Task<bool> DeleteRace(int id)
        {
            var race = await _gameDbContext.Races.FindAsync(id);

            if(race == null)
            {
                return false;
            }

            _gameDbContext.Races.Remove(race);

            await _gameDbContext.SaveChangesAsync();

            return true;
        }
    }
}
