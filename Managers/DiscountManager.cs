using OnlineBookStore.Models;

namespace OnlineBookStore.Managers 
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
        public decimal CalculateDiscountedPrice(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book cannot be null", nameof(book));
            }

            if (book.IsBookOnSale)
            {
                return book.Price * 0.8m;
            }

            return book.Price;
        }
    }
}