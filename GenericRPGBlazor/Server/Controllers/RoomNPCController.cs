using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomNPCController : BaseController
    {
        private IRoomNPCService _service; 
        public RoomNPCController(IRoomNPCService service)
        {
            _service = service;
        }
    }
}
