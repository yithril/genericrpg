using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Client.Services.Interface
{
    public interface IPlayerClientService
    {
        Task<List<PlayerDTO>> GetAllPlayers();
        Task<PlayerDTO> GetPlayerById(string id);
        Task<PlayerDTO> PostPlayer(PlayerDTO player);
        Task<PlayerDTO> UpdatePlayer(PlayerDTO player);
        Task<bool> DeletePlayer(string id);
    }
}
