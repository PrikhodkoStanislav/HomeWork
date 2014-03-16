namespace MyExceptionNamespace
{
    using System;

    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message)
        {
            this.error = "Error: " + message;
        }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        public string error { get; set; }
    }
}
