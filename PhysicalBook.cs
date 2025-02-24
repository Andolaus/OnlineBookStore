namespace OnlineBookStore
{
    /// <summary>
    /// An abstract class representing a physical book in a online book store.
    /// </summary>
    public abstract class PhysicalBook : BaseBook 
    {
        /// <summary>
        /// Gets the number of pages in a physical book.
        /// </summary>
       public int PageCount { get; }

       /// <summary>
       /// Initializes a new instance of a physical book.
       /// </summary>
       /// <param name="title">Title of the physical book.</param>
       /// <param name="authorName">AuthorName of the physical book.</param>
       /// <param name="isbn">The International Standard Book Number for a physical book.</param>
       /// <param name="price">The price of the physical book.</param>
       /// <param name="pageCount">Page count of the physical book.</param>
       /// <exception cref="ArgumentException">Throws argument exception if page count is zero or negative.</exception>
       protected PhysicalBook(string title, string authorName, string isbn, decimal price, int pageCount) 
           : base(title, authorName, isbn, price)
       {
           if (pageCount <= 0)
           {
               throw new ArgumentException(nameof(pageCount), "Page count cannot be less than or equal to zero. " +
                   "Please provide a valid page count.");
           }

           PageCount = pageCount;
       } 

       /// <summary>
       /// Returns a string representation of a physical book.
       /// </summary>
       /// <returns></returns>
       public override string ToString()
       {
           return $"Title: {Title}, Author: {AuthorName}, ISBN: {Isbn}, Price: {Price:C}, Page Count: {PageCount}";
       }
    }
}