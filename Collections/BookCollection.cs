using OnlineBookStore.Managers;
using OnlineBookStore.Models;

namespace OnlineBookStore.Collections 
{
    /// <summary>
    /// A Class representing a collection of books in a online book store.
    /// </summary>
    public class BookCollection 
    {
        private readonly List<Book> _books = new();

        /// <summary>
        /// Adds a book to the collection.
        /// </summary>
        /// <param name="book">Book to add in collection.</param>
        /// <exception cref="ArgumentNullException">Exception thrown if book is null.</exception>
        /// <exception cref="ArgumentException">Exception thrown if a book with same ISBN already exist.</exception>
        public void AddBook (Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null. " +
                    "Please provide a valid book.");
            }

            if (_books.Any(b => b.Isbn == book.Isbn))
            {
                throw new ArgumentException(nameof(book), "Book with same ISBN already exist. " +
                    "Please provide a another book.");
            }

            _books.Add(book);
        }

        /// <summary>
        /// Removes a book from the book collection.
        /// </summary>
        /// <param name="book">Book to remove from collection.</param>
        /// <exception cref="ArgumentNullException">Exception thrown if book is null.</exception>
        /// <exception cref="ArgumentException">Exception thrown if doesn't exist in collection.</exception>
        public void RemoveBook (Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null. " +
                    "Please provide a valid book.");
            }

            if (!_books.Contains(book))
            {
                throw new ArgumentException(nameof(book), "Book does not exist in collection, failed to remove book " +
                    "Please provide a valid book.");
            }

            _books.Remove(book);
        }

        /// <summary>
        /// Returns number of books in the collection.
        /// </summary>
        /// <returns>
        /// The counted number of books in the collection.
        /// </returns>
        public int BookCount () => _books.Count;

        /// <summary>
        /// Returns a list of books in the collection.
        /// </summary>
        /// <returns>
        /// A copy of the list of books in the collection.
        /// </returns>
        public List<Book> GetBooks () => new(_books);

        /// <summary>
        /// Finds a book by ISBN in the collection.
        /// </summary>
        /// <param name="isbn">The ISBN number to use for searching.</param>
        /// <returns>
        /// The book with the same ISBN number.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown if ISBN is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown if method can't find book with same ISBN.</exception>
        public Book FindBookByIsbn (string isbn) 
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException(nameof(isbn), "ISBN cannot be null or empty. " +
                    "Please provide a valid ISBN.");
            }
            
            return _books.FirstOrDefault(book => book.Isbn == isbn)
                ?? throw new ArgumentException(nameof(isbn), "Book with that ISBN does not exist. " +
                    "Please provide a valid ISBN.");
        }

        /// <summary>
        /// Finds a book by title in the collection.
        /// </summary>
        /// <param name="title">Title name used for searching the collection.</param>
        /// <returns>
        /// The book with the same title.
        /// </returns>
        /// <exception cref="ArgumentException">Throws when title is null or empty.</exception>
        /// <exception cref="ArgumentException">Throws when input title doesn't exist.</exception>
        public Book FindBookByTitle (string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException(nameof(title), "Title cannot be null or empty. " +
                    "Please provide a valid title.");
            }

            return _books.FirstOrDefault(book => book.Title == title)
                ?? throw new ArgumentException(nameof(title), "Book with that title does not exist. " +
                    "Please provide a valid title.");
        }
    }
}