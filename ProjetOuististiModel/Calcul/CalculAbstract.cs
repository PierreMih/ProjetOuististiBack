using ProjetOuististiDomain.Enums;
using ProjetOuististiDomain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calculs
{
    public abstract class CalculAbstract
    {
        public Guid Id { get; private set; }
        public float Input1 { get; private set; }
        public float Input2 { get; private set; }

        protected CalculAbstract(float input1, float input2)
        {
            Input1 = input1;
            Input2 = input2;
        }

        private Result? Result;
        public Result GetResult()
        {
            if (Result == null)
            {
                Result = new Result(Calculate(), Id);
            }
                return Result;
        }

        protected abstract float Calculate();

        public abstract OperationTypes getOperationType();
    }
}
