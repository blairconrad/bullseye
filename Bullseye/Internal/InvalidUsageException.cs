#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Bullseye.Internal
{
    using System;

#pragma warning disable CA1032 // Implement standard exception constructors
    public class InvalidUsageException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        public InvalidUsageException(string message) : base(message)
        {
        }
    }
}
