﻿using Microsoft.AspNetCore.Mvc;
using ProjetOuististiApplication.Objects;
using ProjetOuististiDomain.Calcul;

namespace ProjetOuististiApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatriceController : ControllerBase
    {
        private readonly ILogger<CalculatriceController> _logger;

        public CalculatriceController(ILogger<CalculatriceController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Calculate")]
        public string ReceiveCalculAndReturnResult(CalculInputDto calcul)
        {
            return "hello";
            //return new CalculOutputDto(calcul);
        }
    }
}
