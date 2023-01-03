using ProjetOuististiDomain;
using ProjetOuististiDomain.Shared;
using ProjetOuististiDomain.Calcul;

namespace ProjetOuististiApplication.Objects
{
    public class CalculInputDto
    {
        public float input1 { get; set; }
        public float input2 { get; set; }

        public string OperationType { get; set; }

        public static implicit operator CalculAbstract(CalculInputDto calculDto)
        {
            return CalculFactory.BuildFromValuesAndOpType(calculDto.input1, calculDto.input2, calculDto.OperationType);
        }
    }
}
