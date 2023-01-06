using ProjetOuististiDomain.Calculs;
using ProjetOuististiDomain.Results;
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
    }
}
