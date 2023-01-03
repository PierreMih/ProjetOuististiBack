using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiDomain
{
    public class Result
    {
        private Guid _idCalcul;
        public float Value { get; private set; }

        public Result(float resultValue, Guid id)
        {
            Value = resultValue;
            _idCalcul = id;
        }

        public static implicit operator float(Result result) 
        { 
            return result.Value;
        }
    }
}
