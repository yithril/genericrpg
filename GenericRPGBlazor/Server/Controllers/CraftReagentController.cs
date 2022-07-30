using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CraftReagentController : BaseController
    {
        private ICraftReagentService _service;

        public CraftReagentController(ICraftReagentService service)
        {
            _service = service;
        }

    }
}
