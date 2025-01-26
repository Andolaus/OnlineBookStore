using OnlineBookStore.Managers;
using OnlineBookStore.Models;

namespace OnlineBookStore.Collections 
{
    public class BookCollection 
    {
        private readonly List<Book> _books = new();

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

        public int BookCount () => _books.Count;

        public List<Book> GetBooks () => new List<Book>(_books);

        public Book FindBookByIsbn (string isbn) 
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("ISBN cannot be null or empty", nameof(isbn));
            }
            
            return _books.FirstOrDefault(book => book.Isbn == isbn)
                ?? throw new ArgumentException("Book with that ISBN not found", nameof(isbn));
        }

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