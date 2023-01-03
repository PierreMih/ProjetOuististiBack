using ProjetOuististiDomain;
using ProjetOuististiDomain.Shared;
using ProjetOuististiDomain.Calcul;

namespace ProjetOuististiApplication.Objects
{
    public class CalculInputDto
    {
        public float input1;
        public float input2;
        public OperationTypes OperationType;

        public CalculInputDto(float n1, float n2, string opType) 
        { 
            input1 = n1;
            input2 = n2;
            if(Enum.TryParse<OperationTypes>(opType, true, out OperationTypes opTypeAsEnum)) {
                OperationType = opTypeAsEnum;
            }
            else
            {
                throw new Exception($"Type d'opération non reconnu : {opType}");
            }
        }

        public static implicit operator CalculAbstract(CalculInputDto calculDto)
        {
            return CalculFactory.BuildFromValuesAndOpType(calculDto.input1, calculDto.input2, calculDto.OperationType);
        }
    }
}
