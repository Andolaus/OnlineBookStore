using System; 

namespace OnlineBookStore.Exceptions
{
    /// <summary>
    /// Class representing a book not found exception.
    /// </summary>
    public class BookNotFoundException : Exception
    {
        /// <summary>
        /// Default constructor for BookNotFoundException.
        /// </summary>
        public BookNotFoundException()
        {
        }

        /// <summary>
        /// Constructor for BookNotFoundException with a message.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        public BookNotFoundException(string message) 
            : base(message)
        {
        }

        /// <summary>
        /// Constructor for BookNotFoundException with a message and an inner exception.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        /// <param name="inner">The original error that led to this exception.</param>
        public BookNotFoundException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}