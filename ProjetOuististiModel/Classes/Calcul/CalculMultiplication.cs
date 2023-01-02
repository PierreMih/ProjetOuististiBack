using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Classes.Calcul
{
    internal class CalculMultiplication : Calcul
    {
        public override float getResult()
        {
            return this.input1 * this.input2;
        }
    }
}
