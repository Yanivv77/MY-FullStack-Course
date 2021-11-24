using System;
using System.Runtime.Serialization;

namespace ShopProject.Exceptions
{
    [Serializable]
    internal class IllegalArgument : Exception
    {
        public IllegalArgument()
        {
        }

        public IllegalArgument(string message) : base(message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public IllegalArgument(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IllegalArgument(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}