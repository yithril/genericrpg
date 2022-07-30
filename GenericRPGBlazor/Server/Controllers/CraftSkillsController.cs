using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CraftSkillsController : BaseController
    {
        private ICraftSkillService _service; 
        public CraftSkillsController(ICraftSkillService service)
        {
            _service = service;
        }
     }
}
