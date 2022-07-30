using AutoWrapper.Wrappers;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RaceController : BaseController
    {
        private IRaceService _raceService;

        public RaceController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [HttpGet("GetPlayableRaces")]
        public async Task<ApiResponse> GetPlayableRaces()
        {
            return new ApiResponse(await _raceService.GetPlayableRaces());
        }

        [HttpGet("GetRaces")]
        public async Task<ApiResponse> GetRaces()
        {
            return new ApiResponse(await _raceService.GetRaces());
        }

        [HttpGet("GetRaceById/{id}")]
        public async Task<ApiResponse> GetRaceById(int id)
        {
            return new ApiResponse(await _raceService.GetRaceById(id));
        }

        [HttpPost]
        public async Task<ApiResponse> CreateRace(RaceDTO raceDTO)
        {
            return new ApiResponse(await _raceService.CreateRace(raceDTO));
        }

        [HttpPut]
        public async Task<ApiResponse> UpdateRace(RaceDTO raceDTO)
        {
            return new ApiResponse(await _raceService.UpdateRace(raceDTO));
        }

        [HttpDelete]
        public async Task<ApiResponse> DeleteRace(int id)
        {
            return new ApiResponse(await _raceService.DeleteRace(id));
        }
    }
}
