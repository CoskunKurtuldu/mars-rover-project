using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Exceptions
{
    public class MarsRoverException : Exception
    {
        public MarsRoverException()
        {
        }

        public MarsRoverException(string message) : base(message)
        {
        }

        public MarsRoverException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MarsRoverException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
