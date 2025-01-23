namespace OnlineBookStore.Models
{
    public class Customer
    {
        public Guid CustomerID {get; private set;} //https://learn.microsoft.com/en-us/dotnet/api/system.guid.newguid?view=net-9.0 xml dokumentasjon boka, 
        public string FirstName {get; set;}
        public string? MiddleName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string PhoneNumber {get; set;}


        public Customer(string firstName, string lastName, string email, string phoneNumber, string? middleName = null)
        {
            CustomerID = Guid.NewGuid();
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}