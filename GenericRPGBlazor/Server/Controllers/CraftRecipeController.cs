using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftRecipeController : BaseController
    {
        private ICraftRecipeService _service;

        public CraftRecipeController(ICraftRecipeService service)
        {
            _service = service;
        }

    }
}
