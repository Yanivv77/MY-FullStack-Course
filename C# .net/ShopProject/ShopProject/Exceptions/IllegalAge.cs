using System;
using System.Runtime.Serialization;

namespace ShopProject.Exceptions
{
    [Serializable]
    internal class IllegalAge : Exception
    {
        public IllegalAge()
        {
        }

        public IllegalAge(string message) : base(message)
        {
            Console.WriteLine(message);
            Console.WriteLine();

        }

        public IllegalAge(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IllegalAge(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}