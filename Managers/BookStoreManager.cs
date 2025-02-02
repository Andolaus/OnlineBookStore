using OnlineBookStore.Models;
using OnlineBookStore.Collections;

namespace OnlineBookStore.Managers
{
        public class BookStoreManager
    {
        private readonly InventoryManager _inventoryManager; 
        private readonly DiscountManager _discountManager;
        private readonly BookCollection _bookCollection;
        private readonly List<Order> orders = new();

        public void AddBook(Book book, int quantity)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null. " +
                "Please provide a valid book.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException(nameof(quantity), "Quantity must be higher than zero. " +
                "Please provide a valid quantity number.");
            }

            _inventoryManager.AddBookQuantityToInventory(book.Isbn, quantity);
            _bookCollection.AddBook(book);
        }

        public Book FindBook(string titleOrIsbn) 
        {
            if (string.IsNullOrWhiteSpace(titleOrIsbn))
            {
                throw new ArgumentException(nameof(titleOrIsbn), "Title or ISBN cannot be null or empty. " + 
                "Please provide a valid title or ISBN.");
            }

            
        }
    }
}