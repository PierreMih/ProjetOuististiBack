using ProjetOuististiDomain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calcul
{
    public class CalculAddition : CalculAbstract
    {
        public CalculAddition(float input1, float input2) : base(input1, input2)
        {
        }

        protected override float Calculate()
        {
            return Input1 + Input2;
        }

        public override OperationTypes getOperationType()
        {
            return OperationTypes.Addition;
        }
    }
}
