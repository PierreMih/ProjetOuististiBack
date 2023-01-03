using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calcul
{
    internal class CalculSoustraction : CalculAbstract
    {
        public CalculSoustraction(float input1, float input2) : base(input1, input2)
        {
            
        }

        protected override float Calculate()
        {
            return Input1 - Input2;
        }
    }
}
