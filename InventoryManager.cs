namespace OnlineBookStore
{
    /// <summary>
    /// A class that manages the inventory of books in the store.
    /// It adds, removed and gets the quantity of books in the inventory.
    /// </summary>
    public class InventoryManager 
    {
        /// <summary>
        /// A dictionary that stores ISBN numbers of books as keys and quantity of books as values.
        /// </summary>
        private readonly Dictionary<string, int> _bookInventory = new();

        /// <summary>
        /// Adds a ISBN number of a book to the inventory with a quantity.
        /// </summary>
        /// <param name="isbn">The ISBN number of a book.</param>
        /// <param name="quantity">Book quantity to add to inventory.</param>
        /// <exception cref="ArgumentException">Throws when ISBN is null, empty or if quantity is negative.</exception>
        public void AddBookQuantityToInventory(string isbn, int quantity)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException(nameof(isbn), "ISBN number cannot be null or empty. " +
                    "Please provide a valid ISBN number.");
            }

            if (quantity < 0)
            {
                throw new ArgumentException(nameof(quantity), "You have to add a positive quantity number. " +
                    "Please provide a valid quantity number.");
            }

            if (_bookInventory.ContainsKey(isbn))
            {

                _bookInventory[isbn] += quantity;
            }

            else
            {
                _bookInventory[isbn] = quantity;
            }
        }

        /// <summary>
        /// Removes a quantity of a book from the inventory.
        /// </summary>
        /// <param name="isbn">The ISBN number of a book.</param>
        /// <param name="quantity">Book quantity to remove from inventory.</param>
        /// <exception cref="ArgumentException">Throws when ISBN is null, empty or if quantity is negative.</exception>
        /// <exception cref="KeyNotFoundException">Throws when ISBN is not found in inventory.</exception>
        /// <exception cref="InvalidOperationException">Thrown when qantity to remove is higher than stock available.</exception>
        public void RemoveBookQuantityFromInventory(string isbn, int quantity)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException(nameof(isbn), "ISBN number cannot be null or empty. " +
                    "Please provide a valid ISBN number.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException(nameof(quantity), "Quantity must be higher than zero. " +
                    "Please provide a valid quantity number.");
            }

            if (!_bookInventory.ContainsKey(isbn))
            {
                throw new KeyNotFoundException("Book with that ISBN number does not exist in inventory. " +
                    "Please provide a valid ISBN number.");
            }

            int availableQuantity = _bookInventory[isbn];

            if (availableQuantity < quantity)
            {
                throw new InvalidOperationException("Quantity to remove is higher than available quantity. Available quantity is: " + 
                $"{availableQuantity}. Please provide a valid quantity number.");
            }

            _bookInventory[isbn] -= quantity;

            if (_bookInventory[isbn] < 0)
            {
                _bookInventory[isbn] = 0;
            }
        }

        /// <summary>
        /// Gets the quantity of a book in the inventory.
        /// </summary>
        /// <param name="isbn">The ISBN number of a book.</param>
        /// <returns>Number of available stock.</returns>
        /// <exception cref="KeyNotFoundException">Throws when ISBN number does not exist in inventory.</exception>
        public int GetBookQuantityInInventory(string isbn)
        {
            if (_bookInventory.ContainsKey(isbn))
            {
                return _bookInventory[isbn];
            }
            
            else
            {
                throw new KeyNotFoundException("Book with that ISBN number does not exist in inventory. " +
                    "Please provide a valid ISBN number.");
            }
        }

        
    }
}