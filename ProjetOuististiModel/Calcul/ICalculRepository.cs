using ProjetOuististiDomain.Calculs;
using ProjetOuististiDomain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calcul
{
    public interface ICalculRepository
    {
        public void Add(CalculAbstract calcul);
        public IEnumerable<CalculAbstract> GetAll();

        public Result GetResultFromCalcul(Guid calcul);

        public Result Update(CalculAbstract calcul);

        public void Delete(Guid calcul);
    }
}
