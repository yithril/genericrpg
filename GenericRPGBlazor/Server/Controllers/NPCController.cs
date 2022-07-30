using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NPCController : BaseController
    {
        private INPCService _service; 
        public NPCController(INPCService service)
        {
            _service = service;
        }
    }
}
