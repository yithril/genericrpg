using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Services.Interface
{
    public interface IRaceService
    {
        Task<List<RaceDTO>> GetRaces();
        Task<RaceDTO> GetRaceById(int id);
        Task<List<RaceDTO>> GetPlayableRaces();
        Task<RaceDTO> CreateRace(RaceDTO raceDTO);
        Task<RaceDTO> UpdateRace(RaceDTO raceDTO);
        Task<bool> DeleteRace(int id);
    }
}
