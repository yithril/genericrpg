using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : BaseController
    {
        private IWeaponService _service; 
        public WeaponController(IWeaponService service)
        {
            _service = service;
        }
    }
}
