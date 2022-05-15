using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Exceptions
{
    [Serializable]
    public class InvalidPositionException : MarsRoverArgumentException
    {
        public InvalidPositionException()
        {
        }

        public InvalidPositionException(string message) : base(message)
        {
        }

        public InvalidPositionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPositionException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
