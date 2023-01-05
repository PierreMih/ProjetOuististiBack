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

        [HttpPost("/Calculate")]
        public CalculOutputDto ReceiveCalculAndReturnResult(CalculInputDto calcul)
        {
            try
            {
                return new CalculOutputDto(calcul);
            }
            catch (Exception )
            {
                throw;
            }
        }

        [HttpGet("/Statistics")]
        public StatisticsOutputDto GetStatistics()
        {
            return new StatisticsOutputDto
            {
                Additions = 200,
                Soustractions = 350,
                Multiplications = 250,
                Divisions = 300
            };
        }
    }
}
