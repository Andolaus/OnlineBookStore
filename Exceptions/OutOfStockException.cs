using System; 

namespace OnlineBookStore.Exceptions
{
    /// <summary>
    /// Class representing an out of stock exception.
    /// </summary>
    public class OutOfStockException : Exception
    {
        /// <summary>
        /// Default constructor for OutOfStockException.
        /// </summary>
        public OutOfStockException()
        {
        }

        /// <summary>
        /// Constructor for OutOfStockException with a message.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        public OutOfStockException(string message) 
            : base(message)
        {
        }

        /// <summary>
        /// Constructor for OutOfStockException with a message and an inner exception.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        /// <param name="inner">The original error that led to this exception.</param>
        public OutOfStockException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}