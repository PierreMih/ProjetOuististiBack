using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using ProjetOuististiApplication.Objects;
using ProjetOuististiDomain.Calcul;
using ProjetOuististiDomain.Calculs;
using ProjetOuististiEntityFramework.Repositories;

namespace ProjetOuististiApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("OuististiCors")]
    public class CalculatriceController : ControllerBase
    {
        private readonly ILogger<CalculatriceController> _logger;
        private readonly CalculManager _calculManager;
        private readonly ICalculRepository _calculRepository;

        public CalculatriceController(ILogger<CalculatriceController> logger, CalculManager calculManager, ICalculRepository calculRepository)
        {
            _logger = logger;
            _calculManager = calculManager;
            _calculRepository = calculRepository;
        }

        [HttpPost("/Calculate")]
        public CalculOutputDto ReceiveCalculAndReturnResult(CalculInputDto calcul)
        {
            CalculAbstract calc = _calculManager.ReceiveCalcul(calcul.input1, calcul.input2, calcul.OperationType);
            _calculRepository.Add(calc);

            var output = new CalculOutputDto(calc);
            output.output = _calculManager.GetResultFromCalcul(calc);

            return output;
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

        [HttpGet("/AllCalculsWithResults")]
        public IEnumerable<CalculOutputDto> GetAllCalculsWithResults()
        {
            //List <CalculOutputDto> list = new();
            //foreach (CalculAbstract calc in _calculRepository.GetAll())
            //{
            //    list.Add(new(calc));
            //}
            //return list;
            foreach (CalculAbstract calc in _calculRepository.GetAll())
            {
                var output = new CalculOutputDto(calc);
                output.output = _calculManager.GetResultFromCalcul(calc);
                yield return output;
            }
            
        }
    }
}
