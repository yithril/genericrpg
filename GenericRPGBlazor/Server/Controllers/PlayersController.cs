using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AutoWrapper.Wrappers;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.DTO;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlayersController : BaseController
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService service)
        {
            _playerService = service;
        }

        [HttpGet]
        public async Task<ApiResponse> GetPlayers()
        {
            var players = await _playerService.GetAllPlayers(GetUserAuthId());

            return new ApiResponse(players);
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse> GetPlayer(int id)
        {
            var player = await _playerService.GetPlayerById(id);

            if(player.Id == 0)
            {
                return new ApiResponse(404, "Player not found");
            }

            return new ApiResponse(player);
        }

        [HttpPut("{id}")]
        public async Task<ApiResponse> PutPlayer(int id, PlayerDTO playerDTO)
        {
            var updateSuccess = await _playerService.UpdatePlayer(id, playerDTO);

            if (!updateSuccess)
            {
                return new ApiResponse(500, "update failed");
            }

            return new ApiResponse();
        }

        [HttpPost]
        public async Task<ApiResponse> PostPlayer(PlayerDTO playerDTO)
        {
            var player = await _playerService.CreatePlayer(playerDTO, GetUserAuthId());

            if(player.Id == 0)
            {
                return new ApiResponse(500, "player not created");
            }

            return new ApiResponse(playerDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ApiResponse> DeletePlayer(int id)
        {
            var delete = await _playerService.DeletePlayer(id);

            if (!delete)
            {
                return new ApiResponse(500, "delete failed");
            }

            return new ApiResponse();
        }
    }
}
