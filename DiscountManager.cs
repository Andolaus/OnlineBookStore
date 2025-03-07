namespace OnlineBookStore
{
    /// <summary>
    /// Class representing a discount manager for a online book store.
    /// </summary>
    public class DiscountManager 
    {
        /// <summary>
        /// Calculates 20% discount if book is on sale.
        /// </summary>
        /// <param name="book">The book to check if it's on sale.</param>
        /// <returns>Discounted price if sale.</returns>
        /// <exception cref="ArgumentNullException">Throws if book is null.</exception>
        public decimal CalculateDiscountedPrice(BaseBook book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null. " +
                    "Please provide a valid book.");
            }

            if (book.IsBookOnSale)
            {
                return book.Price * 0.8m;
            }

            return book.Price;
        }
    }
}