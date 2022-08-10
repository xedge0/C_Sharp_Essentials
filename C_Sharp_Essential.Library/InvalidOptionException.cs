using System.Runtime.Serialization;

namespace C_Sharp_Essential.Library;

[Serializable]
public class InvalidOptionException : Exception
    {
    public InvalidOptionException() : base() { }
    public InvalidOptionException(string message) : base(message) { }
    public InvalidOptionException(string message, Exception innerException) : base(message, innerException) { }
    protected InvalidOptionException(SerializationInfo info, StreamingContext ctx) : base(info, ctx) { }
    }
