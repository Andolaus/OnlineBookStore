namespace OnlineBookStore
{
    /// <summary>
    /// An abstract base class representing a book in a online book store.
    /// </summary>
    public abstract class BaseBook
    {
        /// <summary>
        /// Gets the title of a book.
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// Gets or the author of a book.
        /// </summary>
        public string AuthorName { get; }
        /// <summary>
        /// Gets the Interational Standard Book Number for a book.
        /// </summary>
        public string Isbn { get; }
        /// <summary>
        /// Gets the price of a book.
        /// </summary>
        public decimal Price { get; private set; }
        /// <summary>
        /// Gets or sets a boolean value to check if a book is on sale.
        /// </summary>
        public bool IsBookOnSale { get; set; } = false;

       /// <summary>
       /// Initializes new instance of a book.
       /// </summary>
       /// <param name="title">Title of the book.</param>
       /// <param name="authorName">Author name of the book.</param>
       /// <param name="isbn">The International Standard Book Number for a book.</param>
       /// <param name="price">The price of the book.</param>
       /// <exception cref="ArgumentException">Throws argument exception when input fields are invalid.</exception>
        protected BaseBook(string title, string authorName, string isbn, decimal price)
        {

        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(nameof(title), "Title cannot be null or empty. " +
                "Please provide a valid title.");
        }

        if (string.IsNullOrWhiteSpace(authorName))
        {
            throw new ArgumentException(nameof(authorName), "Author name cannot be null or empty. " +
                "Please provide a valid author name.");
        }

        if (string.IsNullOrWhiteSpace(isbn))
        {
            throw new ArgumentException(nameof(isbn), "ISBN cannot be null or empty. " +
                "Please provide a valid ISBN.");
        }

        if (price < 0)
        {
            throw new ArgumentException(nameof(price), "Price cannot be negative. " +
                "Please provide a valid price.");
        }

        Title = title; 
        AuthorName = authorName;
        Isbn = isbn;
        Price = price;
        }

        /// <summary>
        /// Sets the price of a book.
        /// </summary>
        /// <param name="price">The new price of a book instance.</param>
        /// <exception cref="ArgumentException">Throws argument exception if price is lower or equal to zero.</exception>
        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException(nameof(price), "Price cannot be negative or zero. " +
                    "Please provide a valid price.");
            }

            Price = price;
        }

        /// <summary>
        /// Returns a description of a book with information about title, author, ISBN, price and if the book is on sale.
        /// </summary>
        /// <returns>
        /// A string with information about the book.
        /// </returns>
        public override string ToString() 
        {
            return $"Title: {Title}\n, Author: {AuthorName}\n, ISBN: {Isbn}\n, Price: {Price:C}\n, On Sale: {IsBookOnSale}\n";
        }

    }
}