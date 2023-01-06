using ProjetOuististiDomain;
using ProjetOuististiDomain.Enums;
using ProjetOuististiDomain.Calculs;
using System.Runtime.Serialization;

namespace ProjetOuististiApplication.Objects
{
    public class CalculInputDto
    {
        public float input1 { get; set; }
        public float input2 { get; set; }

        public string OperationType { get; set; }
    }
}