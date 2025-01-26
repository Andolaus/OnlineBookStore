using OnlineBookStore.Managers;
using OnlineBookStore.Models;

namespace OnlineBookStore.Collections 
{
    public class BookCollection 
    {
        private readonly List<Book> _books = new();

        public void AddBook (Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook (Book book)
        {
            _books.Remove(book);
        }

        public int BookCount () => _books.Count;

        public List<Book> GetBooks () => _books;

        public Book FindBookByIsbn (string isbn) 
        {
            return _books.FirstOrDefault(book => book.Isbn == isbn);
        }

        public Book FindBookByTitle (string title)
        {
            return _books.FirstOrDefault(book => book.Title == title);
        }
    }
}