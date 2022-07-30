using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceSkillController : BaseController
    {
        private IRaceSkillService _service;

        public RaceSkillController(IRaceSkillService service)
        {
            _service = service;
        }

    }
}
