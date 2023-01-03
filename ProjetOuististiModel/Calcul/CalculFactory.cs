using ProjetOuististiDomain.Enums;

namespace ProjetOuististiDomain.Calculs
{
    public static class CalculFactory
    {
        public static CalculAbstract BuildFromValuesAndOpType(float input1, float input2, string opType)
        {
            Enum.TryParse(opType, true, out OperationTypes opTypeAsEnum);
            switch (opTypeAsEnum)
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
