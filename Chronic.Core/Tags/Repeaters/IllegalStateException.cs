using System;

namespace Chronic.Core.Tags.Repeaters
{
    public class IllegalStateException : Exception
    {
        public IllegalStateException(string message) 
            : base(message)
        {
            
        }
    }
}