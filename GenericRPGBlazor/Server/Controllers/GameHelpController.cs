using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameHelpController : BaseController
    {
        private IGameHelpService _service;

        public GameHelpController(IGameHelpService service)
        {
            _service = service;
        }
    }
}
