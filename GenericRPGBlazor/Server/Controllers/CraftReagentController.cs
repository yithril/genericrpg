using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftReagentController : BaseController
    {
        private ICraftReagentService _service;

        public CraftReagentController(ICraftReagentService service)
        {
            _service = service;
        }

    }
}
