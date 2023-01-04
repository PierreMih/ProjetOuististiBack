using ProjetOuististiDomain.Enums;
using ProjetOuististiDomain.Exceptions;

namespace ProjetOuististiDomain.Calculs
{
    public static class CalculFactory
    {
        public static CalculAbstract BuildFromValuesAndOpType(float input1, float input2, string opType)
        {
            if (!Enum.TryParse(opType, true, out OperationTypes opTypeAsEnum))
                throw ThrowException(opType);
            switch (opTypeAsEnum)
            {
                case OperationTypes.Addition : return new CalculAddition(input1, input2);
                case OperationTypes.Soustraction: return new CalculSoustraction(input1, input2);
                case OperationTypes.Multiplication: return new CalculMultiplication(input1, input2);
                case OperationTypes.Division: return new CalculDivision(input1, input2);
                default: throw ThrowException(opType);
            }
        }

        private static OperationTypeEnumException ThrowException(string opType)
        {
            return new OperationTypeEnumException("Type d'opération non implémenté : " + opType);
        }
    }
}
