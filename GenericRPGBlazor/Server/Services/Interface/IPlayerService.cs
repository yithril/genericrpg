using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Services.Interface
{
    public interface IPlayerService
    {
        Task<List<PlayerDTO>> GetAllPlayers(string authId);
        Task<PlayerDTO> GetPlayerById(int id);
        Task<bool> DeletePlayer(int id);
        Task<PlayerDTO> CreatePlayer(PlayerDTO playerDTO, string authId);
        Task<bool> UpdatePlayer(int id, PlayerDTO update);
    }
}
