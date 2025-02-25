using System; 

namespace OnlineBookStore.Exceptions
{
    /// <summary>
    /// Class representing a duplicate book exception.
    /// </summary>
    public class DuplicateBookException : Exception
    {
        /// <summary>
        /// Default constructor for DuplicateBookException.
        /// </summary>
        public DuplicateBookException()
        {
        }

        /// <summary>
        /// Constructor for DuplicateBookException with a message.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        public DuplicateBookException(string message) 
            : base(message)
        {
        }

        /// <summary>
        /// Constructor for DuplicateBookException with a message and an inner exception.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        /// <param name="inner">The original error that led to this exception.</param>
        public DuplicateBookException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}