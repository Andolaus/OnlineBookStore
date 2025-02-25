namespace OnlineBookStore
{
    /// <summary>
    /// A class representing a digital book in a online book store.
    /// </summary>
    public abstract class DigitalBook : BaseBook
    {
        /// <summary>
        /// Initializes a new instance of a digital book.
        /// </summary>
        /// <param name="title">Title of the digital book.</param>
        /// <param name="authorName">AuthorName of the digital book.</param>
        /// <param name="isbn">The International Standard Book Number for a digital book.</param>
        /// <param name="price">The price of the digital book.</param>
        public DigitalBook(string title, string authorName, string isbn, decimal price)
            : base(title, authorName, isbn, price)
        {
        }
    }
}