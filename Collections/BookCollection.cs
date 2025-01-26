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
        /// <param name="book">Book to add in collection</param>
        /// <exception cref="ArgumentNullException">Exception thrown if book is null</exception>
        /// <exception cref="ArgumentException">Exception thrown if a book with same ISBN already exist</exception>
        public void AddBook (Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null");
            }

            if (_books.Any(b => b.Isbn == book.Isbn))
            {
                throw new ArgumentException("Book with same ISBN already exists", nameof(book));
            }

            _books.Add(book);
        }

        /// <summary>
        /// Removes a book from the book collection.
        /// </summary>
        /// <param name="book">Book to remove from collection</param>
        /// <exception cref="ArgumentNullException">Exception thrown if book is null</exception>
        /// <exception cref="ArgumentException">Exception thrown if doesn't exist in collection.</exception>
        public void RemoveBook (Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null");
            }

            if (!_books.Contains(book))
            {
                throw new ArgumentException("Book doesn't exist in collection, failed to remove book", nameof(book));
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
        /// <param name="isbn">The ISBN number to use for searching</param>
        /// <returns>
        /// The book with the same ISBN number.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown if ISBN is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown if method can't find book with same ISBN</exception>
        public Book FindBookByIsbn (string isbn) 
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("ISBN cannot be null or empty", nameof(isbn));
            }
            
            return _books.FirstOrDefault(book => book.Isbn == isbn)
                ?? throw new ArgumentException("Book with that ISBN not found", nameof(isbn));
        }

        /// <summary>
        /// Finds a book by title in the collection.
        /// </summary>
        /// <param name="title">Title name used for searching the collection</param>
        /// <returns>
        /// The book with the same title.
        /// </returns>
        /// <exception cref="ArgumentException">Throws when title is null or empty.</exception>
        /// <exception cref="ArgumentException">Throws when input title doesn't exist.</exception>
        public Book FindBookByTitle (string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null or empty", nameof(title));
            }

            return _books.FirstOrDefault(book => book.Title == title)
                ?? throw new ArgumentException("Book with that title does not exist", nameof(title));
        }
    }
}