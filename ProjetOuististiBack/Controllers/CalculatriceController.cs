using Microsoft.AspNetCore.Mvc;

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

        //[HttpPost(Name = "Calculate")]
        //public float ReceiveCalculAndReturnResult(CalculDto calcul)
        //{
        //    return 10;
        //}
    }
}
