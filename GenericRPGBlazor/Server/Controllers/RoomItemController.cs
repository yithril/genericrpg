using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoomItemController : BaseController
    {
        private IRoomItemService _service; 
        
        public RoomItemController(IRoomItemService service)
        {
            _service = service;
        }
    }
}
