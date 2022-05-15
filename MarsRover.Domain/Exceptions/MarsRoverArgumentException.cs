using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Exceptions
{
    [Serializable]
    public class MarsRoverArgumentException : MarsRoverException
    {
        public MarsRoverArgumentException()
        {
        }

        public MarsRoverArgumentException(string message) : base(message)
        {
        }

        public MarsRoverArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

