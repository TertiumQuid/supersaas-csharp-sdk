using System;
namespace SuperSaaS.CSharp.SDK
{
    public class SSSException : Exception
    {
        public SSSException()
        {
        }

        public SSSException(string message)
        : base(message)
        {
        }

        public SSSException(string message, Exception inner)
        : base(message, inner)
        {
        }

    }
}
