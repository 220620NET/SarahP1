using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels
{
    [System.Serializable]
    public class RecordNotFoundException : System.Exception
    {
        public RecordNotFoundException() { }
        public RecordNotFoundException(string message) : base(message) { }
        public RecordNotFoundException(string message, System.Exception inner) : base(message, inner) { }
        protected RecordNotFoundException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class UsernameNotAvailable : System.Exception
    {
        public UsernameNotAvailable() { }
        public UsernameNotAvailable(string message) : base(message) { }
        public UsernameNotAvailable(string message, System.Exception inner) : base(message, inner) { }
        protected UsernameNotAvailable(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class InvalidCredentialsException : System.Exception
    {
        public InvalidCredentialsException() { }
        public InvalidCredentialsException(string message) : base(message) { }
        public InvalidCredentialsException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidCredentialsException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
