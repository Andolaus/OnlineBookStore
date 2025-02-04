using OnlineBookStore.Managers;

namespace OnlineBookStore.Models
{
    /// <summary>
    /// A class representing an order for a book in a online book store.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets an unique identifier for an order.
        /// </summary>
        public Guid OrderID { get; } = Guid.NewGuid();
        /// <summary>
        /// Gets an unique identifier for a customer.
        /// </summary>
        public Guid CustomerID { get; }
        /// <summary>
        /// Gets first name of a customer.
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// Gets last name of a customer.
        /// </summary>
        public string LastName { get; }
        /// <summary>
        /// Gets email of a customer.
        /// </summary>
        public string Email { get; }
        /// <summary>
        /// Gets phone number of a customer.
        /// </summary>
        public string PhoneNumber { get; }
        /// <summary>
        /// Gets a book to use in a order.
        /// </summary>
        public Book Book { get; }
        /// <summary>
        /// Gets the date of an order.
        /// </summary>
        public DateTime OrderDate { get; } = DateTime.Now;
        /// <summary>
        /// Gets the total amount of an order.
        /// </summary>
        public decimal OrderAmount { get; }

        /// <summary>
        /// Initializes a new instance of an order.
        /// </summary>
        /// <param name="customer">The customer who is purchasing a book.</param>
        /// <param name="book">The book being purchased.</param>
        /// <param name="discountManager">Manages discounts if there is a sale.</param>
        /// <exception cref="ArgumentNullException">Thrown when Customer, Book or DiscountManager is null.</exception>
        public Order(Customer customer, Book book, DiscountManager discountManager)
        {   
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null. " +
                    "Please provide a valid customer.");
            }

            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null. " +
                    "Please provide a valid book.");
            }

            if (discountManager == null)
            {
                throw new ArgumentNullException(nameof(discountManager), "Discount manager cannot be null. " +
                    "Please provide a valid discount manager.");
            }


            CustomerID = customer.CustomerID;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
            PhoneNumber = customer.PhoneNumber;
            Book = book;
            OrderAmount = discountManager.CalculateDiscountedPrice(book);
        }
        /// <summary>
        /// Returns a string representation of an order.
        /// </summary>
        /// <returns>A string representation of an order with customer information</returns>
        public override string ToString()
        {
            return $"Order ID: {OrderID}\nCustomer: {FirstName} {LastName}\nEmail: {Email}\nPhone Number: {PhoneNumber}\nBook Title: {Book.Title}\nOrder Date: {OrderDate}\nOrder Amount: {OrderAmount:C}";
        }
    }
}