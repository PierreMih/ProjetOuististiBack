using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain.Exceptions
{
    public class OperationTypeEnumException : Exception
    {
        public OperationTypeEnumException(string message) : base(message) { }
    }
}
