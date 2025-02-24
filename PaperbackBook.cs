namespace OnlineBookStore 
{
    /// <summary>
    /// A class representing a paperback book in a online book store.
    /// </summary>
    public class PaperbackBook : PhysicalBook
    {
       /// <summary>
       /// Initializes a new instance of a paperback book.
       /// </summary>
       /// <param name="title">Title of the paperback book.</param>
       /// <param name="authorName">AuthorName of the paperback book.</param>
       /// <param name="isbn">The International Standard Book Number for a paperback book.</param>
       /// <param name="price">The price of the paperback book.</param>
       /// <param name="pageCount">Page count of the paperback book.</param>
        public PaperbackBook(string title, string authorName, string isbn, decimal price, int pageCount) 
        : base(title, authorName, isbn, price, pageCount)
        {
        }

    }
}