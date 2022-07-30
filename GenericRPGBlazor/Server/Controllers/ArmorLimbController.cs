using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmorLimbController : BaseController
    {
        private IArmorLimbService _service;

        public ArmorLimbController(IArmorLimbService service)
        {
            _service = service;
        }
    }
}
