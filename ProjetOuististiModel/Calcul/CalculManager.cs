using ProjetOuististiDomain.Calculs;
using ProjetOuististiDomain.Results;
using ProjetOuististiDomain.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calcul
{
    public class CalculManager
    {
        public readonly ICalculRepository _calculRepository;

        public CalculManager(ICalculRepository calculRepository)
        {
            _calculRepository = calculRepository;
        }

        public CalculAbstract ReceiveCalcul(float input1, float input2, string operationType) 
        {
            return CalculFactory.BuildFromValuesAndOpType(input1, input2, operationType);
        }

        public Result GetResultFromCalcul(CalculAbstract calcul)
        {
            Result res = _calculRepository.GetResultFromCalcul(calcul.Id);
            if ( res == null)
            {
                res = calcul.GetResult();
                _calculRepository.Update(calcul);
            }
            return res;
        }

        public bool DeleteCalcul(Guid id)
        {
            try
            {
                _calculRepository.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Statistics GetStatistics()
        {
            var calcs = _calculRepository.GetAll();
            var stats = new Statistics
            {
                Additions = calcs.Where(c => c.getOperationType() == Enums.OperationTypes.Addition).Count(),
                Soustractions = calcs.Where(c => c.getOperationType() == Enums.OperationTypes.Soustraction).Count(),
                Multiplications = calcs.Where(c => c.getOperationType() == Enums.OperationTypes.Multiplication).Count(),
                Divisions = calcs.Where(c => c.getOperationType() == Enums.OperationTypes.Division).Count()
            };
            return stats;
        }
    }
}
