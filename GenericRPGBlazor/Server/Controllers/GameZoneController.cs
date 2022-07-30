using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameZoneController : BaseController
    {
        private IGameZoneService _service;

        public GameZoneController(IGameZoneService service)
        {
            _service = service;
        }

     }
}
