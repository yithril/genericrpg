using AutoWrapper.Wrappers;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : BaseController
    {
        private IRaceService _raceService;

        public RaceController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [Authorize]
        [HttpGet("GetPlayableRaces")]
        public async Task<ApiResponse> GetPlayableRaces()
        {
            return new ApiResponse(await _raceService.GetPlayableRaces());
        }

        [Authorize]
        [HttpGet("GetRaces")]
        public async Task<ApiResponse> GetRaces()
        {
            return new ApiResponse(await _raceService.GetRaces());
        }

        [Authorize]
        [HttpGet("GetRaceById/{id}")]
        public async Task<ApiResponse> GetRaceById(int id)
        {
            return new ApiResponse(await _raceService.GetRaceById(id));
        }

        [HttpPost]
        [Authorize("read:admin")]
        public async Task<ApiResponse> CreateRace(RaceDTO raceDTO)
        {
            return new ApiResponse(await _raceService.CreateRace(raceDTO));
        }

        [HttpPut]
        [Authorize("read:admin")]
        public async Task<ApiResponse> UpdateRace(RaceDTO raceDTO)
        {
            return new ApiResponse(await _raceService.UpdateRace(raceDTO));
        }

        [HttpDelete]
        [Authorize("read:admin")]
        public async Task<ApiResponse> DeleteRace(int id)
        {
            return new ApiResponse(await _raceService.DeleteRace(id));
        }
    }
}
