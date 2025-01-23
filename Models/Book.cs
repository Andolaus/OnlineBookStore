namespace OnlineBookStore
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
        Title = title; 
        AuthorName = authorName;
        Isbn = isbn;
        Price = price;
        QuantityInStock = quantityInStock;
        }
    }
}