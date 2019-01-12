using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class CreatePostException : Exception
    {
        public CreatePostException()
        {
        }

        public CreatePostException(string message) : base(message)
        {
        }

        public CreatePostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CreatePostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
