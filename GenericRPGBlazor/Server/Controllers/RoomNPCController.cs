using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoomNPCController : BaseController
    {
        private IRoomNPCService _service; 
        public RoomNPCController(IRoomNPCService service)
        {
            _service = service;
        }
    }
}
