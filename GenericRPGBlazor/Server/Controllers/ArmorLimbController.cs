using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ArmorLimbController : BaseController
    {
        private IArmorLimbService _service;

        public ArmorLimbController(IArmorLimbService service)
        {
            _service = service;
        }
    }
}
