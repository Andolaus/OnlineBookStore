namespace OnlineBookStore
{
    /// <summary>
    /// A class representing a hardcover book in a online book store.
    /// </summary>
    public class HardcoverBook : PhysicalBook
    {

        /// <summary>
       /// Initializes a new instance of a hardcover book.
       /// </summary>
       /// <param name="title">Title of the hardcover book.</param>
       /// <param name="authorName">AuthorName of the hardcover book.</param>
       /// <param name="isbn">The International Standard Book Number for a hardcover book.</param>
       /// <param name="price">The price of the hardcover book.</param>
       /// <param name="pageCount">Page count of the hardcover book.</param>
        public HardcoverBook(string title, string authorName, string isbn, decimal price, int pageCount)
            : base(title, authorName, isbn, price, pageCount)
        {
        }

    }
}