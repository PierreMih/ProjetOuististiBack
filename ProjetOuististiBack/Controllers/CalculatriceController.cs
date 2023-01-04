using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using ProjetOuististiApplication.Objects;
using ProjetOuististiDomain.Calculs;

namespace ProjetOuististiApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("OuististiCors")]
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
