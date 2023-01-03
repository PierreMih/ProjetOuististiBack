using ProjetOuististiDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calculs
{
    public class CalculSoustraction : CalculAbstract
    {
        public CalculSoustraction(float input1, float input2) : base(input1, input2)
        {
            
        }

        protected override float Calculate()
        {
            return Input1 - Input2;
        }

        public override OperationTypes getOperationType()
        {
            return OperationTypes.Soustraction;
        }
    }
}
