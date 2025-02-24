namespace OnlineBookStore
{
    /// <summary>
    /// A class representing an ebook in a online book store.
    /// </summary>
    public class Ebook : BaseBook
    {
        /// <summary>
        /// Gets the file format of the ebook.
        /// </summary>
        public string FileFormat { get; }

        /// <summary>
        /// Initializes a new instance of an ebook.
        /// </summary>
        /// <param name="title">Title of the ebook.</param>
        /// <param name="authorName">AuthorName of the ebook.</param>
        /// <param name="isbn">The International Standard Book Number for an ebook.</param>
        /// <param name="price">The price of the ebook.</param>
        /// <param name="fileFormat">The fileformat of the ebook.</param>
        public Ebook(string title, string authorName, string isbn, decimal price, string fileFormat)
            : base(title, authorName, isbn, price)
        {
            if (string.IsNullOrWhiteSpace(fileFormat))
            {
                throw new ArgumentException(nameof(fileFormat), "File format cannot be null or empty. " +
                    "Please provide a valid file format.");
            }

            FileFormat = fileFormat;
        }

        /// <summary>
        /// Returns a string representation of an ebook.
        /// </summary>
        /// <returns>Returns the base toString method.</returns>
        public override string ToString()
        {
            return $"Title: {Title}, Author: {AuthorName}, ISBN: {Isbn}, Price: {Price:C} File Format: {FileFormat}";
        }
    }
}