namespace OnlineBookStore.Models
{
    public class Book
    {
        public string Title {get; set;}
        public string AuthorName {get; set;}
        public string Isbn {get; set;}
        public decimal Price {get; set;}
        public bool IsBookOnSale {get; set;} = false;
        public int QuantityInStock {get; private set;}

        public Book(string title, string authorName, string isbn, int quantityInStock, decimal price)
        {

        if(string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title cannot be null or empty", nameof(title));
        }
        if(string.IsNullOrWhiteSpace(authorName))
        {
            throw new ArgumentException("Author name cannot be null or empty", nameof(authorName));
        }
        if(string.IsNullOrWhiteSpace(isbn))
        {
            throw new ArgumentException("ISBN cannot be null or empty", nameof(isbn));
        }
        if(quantityInStock < 0)
        {
            throw new ArgumentException("Quantity in stock cannot be less than 0", nameof(quantityInStock));
        }
        if(price < 0)
        {
            throw new ArgumentException("Price cannot be less than 0", nameof(price));
        }

        Title = title; 
        AuthorName = authorName;
        Isbn = isbn;
        Price = price;
        QuantityInStock = quantityInStock;
        }

        public string GetDetailsAboutBook() 
        {
            return $"Title: {Title}, Author: {AuthorName}, ISBN: {Isbn}, Price: {Price}, Stock: {QuantityInStock}, On Sale: {IsBookOnSale}";
        }

    }
}