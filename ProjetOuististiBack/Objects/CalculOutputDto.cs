using ProjetOuististiDomain.Calculs;

namespace ProjetOuististiApplication.Objects
{
    public class CalculOutputDto
    {
        public float input1;
        public float input2;
        public string OperationType;
        public float output;

        public CalculOutputDto(CalculAbstract ca) 
        { 
            input2 = ca.Input1; 
            input1 = ca.Input2;
            OperationType = ca.getOperationType().ToString();
            output = ca.GetResult();
        }
    }
}
