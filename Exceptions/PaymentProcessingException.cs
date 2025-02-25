using System; 

namespace OnlineBookStore.Exceptions
{
    /// <summary>
    /// Class representing a payment processing exception.
    /// </summary>
    public class PaymentProcessingException : Exception
    {
        /// <summary>
        /// Default constructor for PaymentProcessingException.
        /// </summary>
        public PaymentProcessingException()
        {
        }

        /// <summary>
        /// Constructor for PaymentProcessingException with a message.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        public PaymentProcessingException(string message) 
            : base(message)
        {
        }

        /// <summary>
        /// Constructor for PaymentProcessingException with a message and an inner exception.
        /// </summary>
        /// <param name="message">Message that explains the reason for the exception.</param>
        /// <param name="inner">The original error that led to this exception.</param>
        public PaymentProcessingException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}