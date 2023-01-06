using ProjetOuististiDomain.Calculs;

namespace ProjetOuististiApplication.Objects
{
    public class CalculOutputDto
    {
        public float input1 { get; set; }
        public float input2 { get; set; }
        public string OperationType { get; set; }
        public float output { get; set; }

        public string guid { get; set; }

        public CalculOutputDto(CalculAbstract ca) 
        { 
            input1 = ca.Input1; 
            input2 = ca.Input2;
            OperationType = ca.getOperationType().ToString();
            output = ca.GetResult();
            guid = ca.Id.ToString();
        }
    }
}
