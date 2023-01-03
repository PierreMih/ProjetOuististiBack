using ProjetOuististiDomain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Calcul
{
    public static class CalculFactory
    {
        public static CalculAbstract BuildFromValuesAndOpType(float input1, float input2, OperationTypes opType)
        {
            switch(opType)
            {
                case OperationTypes.Addition : return new CalculAddition(input1, input2);
                case OperationTypes.Soustraction: return new CalculSoustraction(input1, input2);
                case OperationTypes.Multiplication: return new CalculMultiplication(input1, input2);
                case OperationTypes.Division: return new CalculDivision(input1, input2);
                default: throw new Exception("Type d'opération non implémenté.");
            }
        }
    }
}
