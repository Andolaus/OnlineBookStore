using OnlineBookStore.Models;
using OnlineBookStore.Collections;

namespace OnlineBookStore.Managers
{
    /// <summary>
    /// Class managing inventory management, book searches, and processing orders in a online book store.
    /// </summary>
        public class BookStoreManager
    {
        private readonly InventoryManager _inventoryManager; 
        private readonly DiscountManager _discountManager;
        private readonly BookCollection _bookCollection;
        private readonly List<Order> _orders = new();

        /// <summary>
        /// Initializes a new instance of a book store manager.
        /// </summary>
        /// <param name="inventoryManager">Inventory manager instance.</param>
        /// <param name="discountManager">Discount manager instance.</param>
        /// <param name="bookCollection">Book collection instance.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BookStoreManager(InventoryManager inventoryManager, DiscountManager discountManager, BookCollection bookCollection)
        {
            _inventoryManager = inventoryManager ?? throw new ArgumentNullException(nameof(inventoryManager), "InventoryManager cannot be null. " +
            "Please provide a valid inventory manager.");
            _discountManager = discountManager ?? throw new ArgumentNullException(nameof(discountManager), "DiscountManager cannot be null. " +
            "Please provide a valid discount manager.");
            _bookCollection = bookCollection ?? throw new ArgumentNullException(nameof(bookCollection), "BookCollection cannot be null. " +
            "Please provide a valid book collection.");
        }

        /// <summary>
        /// Adds a book to the inventory and book collection.
        /// </summary>
        /// <param name="book">The book to add.</param>
        /// <param name="quantity">Quantity to add in inventory.</param>
        /// <exception cref="ArgumentNullException">Thrown if book is null.</exception>
        /// <exception cref="ArgumentException">Thorwn if quantity is less than or equal to zero.</exception>
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

        /// <summary>
        /// Finds a book by title or ISBN.
        /// </summary>
        /// <param name="titleOrIsbn">Title or ISBN of book to search.</param>
        /// <returns>
        /// The book found by title or ISBN.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown if title or ISBN is empty or null.</exception>
        /// <exception cref="KeyNotFoundException">Thrown if title or ISBN does not exist.</exception>
        public Book FindBook(string titleOrIsbn) 
        {
            if (string.IsNullOrWhiteSpace(titleOrIsbn))
            {
                throw new ArgumentException(nameof(titleOrIsbn), "Title or ISBN cannot be null or empty. " + 
                "Please provide a valid title or ISBN.");
            }

            var book = _bookCollection.FindBookByTitle(titleOrIsbn) ?? _bookCollection.FindBookByIsbn(titleOrIsbn);

            if (book == null)
            {
                throw new KeyNotFoundException("Book with that title or ISBN does not exist. " +
                "Please provide a valid title or ISBN.");
            }

            return book;

        }
        /// <summary>
        /// Purchases a book for a customer.
        /// </summary>
        /// <param name="customer">Customer purchasing a book.</param>
        /// <param name="isbn">ISBN numbeer of book to buy.</param>
        /// <returns>
        /// The order of the book purchased.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown if customer is null.</exception>
        /// <exception cref="ArgumentException">Thrown if ISBN is null or empty.</exception>
        /// <exception cref="InvalidOperationException">Thrown if book is lesser or equal to zero.</exception>
        /// <exception cref="KeyNotFoundException">Thrown if invalid ISBN is used.</exception>
        public Order PurchaseBook(Customer customer, string isbn)
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

            Book book = _bookCollection.FindBookByIsbn(isbn) ?? throw new KeyNotFoundException("Book with that ISBN does not exist. " +
            "Please provide a valid ISBN.");

            _inventoryManager.RemoveBookQuantityFromInventory(isbn, 1);

            decimal price = _discountManager.CalculateDiscountedPrice(book);

            Order order = new(customer, book, _discountManager);
            _orders.Add(order);

            return order;
        }

        /// <summary>       
        /// Gets the order history of the book store.
        /// </summary>
        public List<Order> GetOrderHistory() => new(_orders);
    }
}