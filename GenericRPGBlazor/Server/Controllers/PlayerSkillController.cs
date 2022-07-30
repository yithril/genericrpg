using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerSkillController : BaseController
    {
        private IPlayerSkillService _service;

        public PlayerSkillController(IPlayerSkillService service)
        {
            _service = service;
        }

     }
}
