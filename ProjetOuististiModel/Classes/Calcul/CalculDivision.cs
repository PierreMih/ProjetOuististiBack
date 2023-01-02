using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Classes.Calcul
{
    internal class CalculDivision : Calcul
    {
        public override float getResult()
        {
            if (this.input2 == 0) throw new DivideByZeroException("La division par 0 est interdite");
            return this.input1 / this.input2;
        }
    }
}
