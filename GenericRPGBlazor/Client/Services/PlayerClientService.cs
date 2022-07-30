using GenericRPGBlazor.Client.Services.Interface;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Client.Services
{
    public class PlayerClientService : IPlayerClientService
    {
        private IApiService _apiService;

        public PlayerClientService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<PlayerDTO>> GetAllPlayers()
        {
            var endpoint = "api/Player";

            return await _apiService.Get<List<PlayerDTO>>(endpoint);
        }

        public async Task<PlayerDTO> GetPlayerById(string id)
        {
            var endpoint = "api/Player/" + id;

            return await _apiService.Get<PlayerDTO>(endpoint);
        }

        public async Task<PlayerDTO> PostPlayer(PlayerDTO player)
        {
            var endpoint = "api/Player";

            return await _apiService.Post<PlayerDTO>(endpoint, player);
        }

        public async Task<PlayerDTO> UpdatePlayer(PlayerDTO player)
        {
            var endpoint = "api/Player";

            return await _apiService.Put<PlayerDTO>(endpoint, player);
        }

        public async Task<bool> DeletePlayer(string id)
        {
            var endpoint = "api/Player/" + id;

            return await _apiService.Delete<bool>(endpoint);
        }
    }
}
