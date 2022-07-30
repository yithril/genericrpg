﻿using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRPGBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LimbController : BaseController
    {
        private ILimbService _service;

        public LimbController(ILimbService service)
        {
            _service = service;
        }
    }
}
