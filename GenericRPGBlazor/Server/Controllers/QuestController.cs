using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestController : BaseController
    {
        private IQuestService _service;

        public QuestController(IQuestService service)
        {
            _service = service;
        }

     }
}
