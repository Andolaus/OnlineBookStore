using OnlineBookStore.Models;
using OnlineBookStore.Collections;

namespace OnlineBookStore.Managers
{
        public class BookStoreManager
    {
        private readonly InventoryManager _inventoryManager; 
        private readonly DiscountManager _discountManager;
        private readonly BookCollection _bookCollection;
        private readonly List<Order> _orders = new();

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

            return _bookCollection.FindBookByTitle(titleOrIsbn) ?? _bookCollection.FindBookByIsbn(titleOrIsbn);

        }

        public void PurchaseBook(Customer customer, string isbn)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null. " +
                "Please provide a valid customer.");
            }

            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException(nameof(isbn), "ISBN cannot be null or empty. " +
                "Please provide a valid ISBN.");
            }

            if (_inventoryManager.GetBookQuantityInInventory(isbn) <= 0)
            {
                throw new InvalidOperationException("Book is out of stock. " +
                "Please try again later.");
            }

            Book book = _bookCollection.FindBookByIsbn(isbn);
            _inventoryManager.RemoveBookQuantityFromInventory(isbn, 1);

            Order order = new(customer, book, _discountManager);
            _orders.Add(order);

            Console.WriteLine("Book purchased successfully." + "\n" + 
            $"Customer {customer.CustomerFullName()} purchased {book.Title} for {book.Price}.");
        }

        public List<Order> GetOrderHistory() => new(_orders);
    }
}