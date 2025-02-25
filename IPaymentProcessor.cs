namespace OnlineBookStore
{
    /// <summary>
    /// Interface representing a payment processor for a online book store.
    /// </summary>
    public interface IPaymentProcessor
    {
        /// <summary>
        /// Process a payment for a set amount of money. 
        /// </summary>
        /// <param name="amount">Amount to be paid.</param>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>True if payment is successful, false if it is not successful.</returns>
        bool ProcessPayment(decimal amount, Guid transactionId);

        /// <summary>
        /// Refunds a payment.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="amount">Amount to refund.</param>
        /// <returns>True if refund is successful, false if it is not successful.</returns>
        bool RefundPayment(Guid transactionId, decimal amount);

        /// <summary>
        /// Cancels a payment.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>True if cancellation is successful, false if it is not successful.</returns>
        bool CancelPayment(Guid transactionId);

        /// <summary>
        /// Gets the payment status of a transaction.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>A string representing the payment status</returns>
        string GetPaymentStatus(Guid transactionId);

    }
}