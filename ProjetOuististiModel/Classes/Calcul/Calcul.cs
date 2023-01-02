using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Classes.Calcul
{
    internal abstract class Calcul
    {
        protected float input1;
        protected float input2;

        public abstract float getResult();
    }
}
