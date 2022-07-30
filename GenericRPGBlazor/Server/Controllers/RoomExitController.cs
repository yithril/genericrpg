using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoomExitController : BaseController
    {
        private IRoomExitService _service; 
        
        public RoomExitController(IRoomExitService service)
        {
            _service = service;
        }
    }
}
