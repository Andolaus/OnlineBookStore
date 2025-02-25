namespace OnlineBookStore
{
    /// <summary>
    /// A class representing an audio book in a online book store.
    /// </summary>
    public class AudioBook : DigitalBook
    {
        /// <summary>
        /// Gets the length of the audio book.
        /// </summary>
        public int LengthInMinutes { get; }

        /// <summary>
       /// Initializes a new instance of a audio book.
       /// </summary>
       /// <param name="title">Title of the audio book.</param>
       /// <param name="authorName">AuthorName of the audio book.</param>
       /// <param name="isbn">The International Standard Book Number for a audio book.</param>
       /// <param name="price">The price of the audio book.</param>
       /// <param name="lengthInMinutes">Page count of the audio book.</param>
       /// <exception cref="ArgumentException">Throws argument exception if length of audio book is zero or negative.</exception>
        public AudioBook(string title, string authorName, string isbn, decimal price, int lengthInMinutes)
            : base(title, authorName, isbn, price)
        {
            if (lengthInMinutes <= 0)
            {
                throw new ArgumentException(nameof(lengthInMinutes), "Length in minutes cannot be less than or equal to zero. " +
                    "Please provide length in minutes of the audio book.");
            }
            
            LengthInMinutes = lengthInMinutes;
        }

        /// <summary>
        /// Returns a string representation of an audio book.
        /// </summary>
        /// <returns>Returns information about a audio book.</returns>
        public override string ToString()
        {
            return $"Title: {Title}, Author: {AuthorName}, ISBN: {Isbn}, Price: {Price:C}, Length in minutes: {LengthInMinutes}";
        }
    }
}