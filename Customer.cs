namespace OnlineBookStore
{
    /// <summary>
    /// Class representing information about a customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets unique ID for a customer.
        /// </summary>
        public Guid CustomerID { get; private set; } 
        /// <summary>
        /// Gets or sets a customer's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets a customer's middle name.
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// Gets or sets a customer's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets a customer's email address.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets a customer's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Initializez new instance of a customer.
        /// </summary>
        /// <param name="firstName">Customer's first name.</param>
        /// <param name="lastName">Customer's last name.</param>
        /// <param name="email">Customer's email adress.</param>
        /// <param name="phoneNumber">Customer's phone number.</param>
        /// <param name="middleName">Customer's middlename.</param>
        /// <exception cref="ArgumentException">Throws exepction when input is not valid.</exception>
        public Customer(string firstName, string lastName, string email, string phoneNumber, string? middleName = null)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException(nameof(firstName), "First name cannot be null or empty. " +
                    "Please provide a valid first name.");
            }

            if (middleName != null && string.IsNullOrWhiteSpace(middleName))
            {
                throw new ArgumentException(nameof(middleName), "Middle name cannot be empty. " +
                    "Please provide a valid middle name.");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException(nameof(lastName), "Last name cannot be null or empty. " +
                    "Please provide a valid last name.");
            }

            if (String.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new ArgumentException(nameof(email), "Email cannot be null or empty and must contain '@'. " +
                    "Please provide a valid email.");
            }

            if(String.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException(nameof(phoneNumber), "Phone number cannot be null or empty. " +
                    "Please provide a valid phone number.");
            }

            CustomerID = Guid.NewGuid();
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Returns the full name of a customer.
        /// </summary>
        /// <returns>
        /// Returns customer's full name as a string.
        /// </returns>
        public string GetFullName() 
        {
          return MiddleName == null
            ? $"{FirstName} {LastName}"
            : $"{FirstName} {MiddleName} {LastName}";
        }

        /// <summary>
        /// Returns a string with information about a customer.
        /// </summary>
        /// <returns>
        /// A string with information about a customer.
        /// </returns>
        public override string ToString()
        {
            return $"Customer ID: {CustomerID}\nName: {GetFullName()}\nEmail: {Email}\nPhone Number: {PhoneNumber}\n";
        }
  
    }
}