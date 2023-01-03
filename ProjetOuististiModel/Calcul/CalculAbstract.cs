using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calcul
{
    internal abstract class CalculAbstract
    {
        public Guid Id { get; private set; }
        public float Input1 { get; private set; }
        public float Input2 { get; private set; }

        public CalculAbstract(float input1, float input2)
        {
            Input1 = input1;
            Input2 = input2;
        }

        public Result? Result { 
            get{
                if(Result == null)
                {
                    CalculateAndReturnResult();
                }
                return Result;
            }
            set { Result = value; }
        }
        private float CalculateAndReturnResult()
        {
            Result = new Result(Calculate(), Id);
            if (Result == null) { throw new Exception("Résultat non généré?! Erreur!"); }
            return Result.Value;
        }

        protected abstract float Calculate();
    }
}
