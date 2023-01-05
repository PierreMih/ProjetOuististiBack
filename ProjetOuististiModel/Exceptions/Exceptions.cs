using System.Runtime.Serialization;

namespace ProjetOuististiDomain.Exceptions
{
    [Serializable]
    public class OperationTypeEnumException : Exception
    {
        public OperationTypeEnumException()
        {
        }

        public OperationTypeEnumException(string message) : base(message) { }

        public OperationTypeEnumException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OperationTypeEnumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
