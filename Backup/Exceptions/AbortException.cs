using System;

namespace Backup.Exceptions
{
    public class AbortException : Exception
    {
        public AbortException(string message, Exception cause = null) : base(message, cause)
        {
        }
    }
}