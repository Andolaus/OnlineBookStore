using OnlineBookStore;

class Program 
{
    static void Main(string[] args)
    {
        /*
        // Lager nødvendige instanser for alle klassene.
        InventoryManager inventoryManager = new();
        DiscountManager discountManager = new();
        BookCollection bookCollection = new();
        BookStoreManager bookStoreManager = new(inventoryManager, discountManager, bookCollection);

        // Lager bokobjekter
        Book eyeOfTheWorld = new Book("The Eye of the World", "Robert Jordan", "978-0812511819", 299m);
        Book theGreatHunt = new Book("The Great Hunt", "Robert Jordan", "978-0812517729", 299m);
        Book theDragonReborn = new Book("The Dragon Reborn", "Robert Jordan", "978-0812513714", 299m);
        Book theShadowRising = new Book("The Shadow Rising", "Robert Jordan", "978-0812513738", 320m);
        Book theFiresOfHeaven = new Book("The Fires of Heaven", "Robert Jordan", "978-0812513752", 320m);
        Book lordOfChaos = new Book("Lord of Chaos", "Robert Jordan", "978-081513722", 320m);
        Book aCrownOfSwords = new Book("A Crown of Swords", "Robert Jordan", "978-0312857677", 350m);
        Book thePathOfDaggers = new Book("The Path of Daggers", "Robert Jordan", "978-0812550290", 350m);
        Book wintersHeart = new Book("Winter's Heart", "Robert Jordan", "978-0812575583", 350m);
        Book crossroadsOfTwilight = new Book("Crossroads of Twilight", "Robert Jordan", "978-0312864590", 320m);
        Book knifeOfDreams = new Book("Knife of Dreams", "Robert Jordan", "978-0312873073", 320m);
        Book theGatheringStorm = new Book("The Gathering Storm", "Robert Jordan & Brandon Sanderson", "978-0765302304", 499m);
        Book towersOfMidnight = new Book("Towers of Midnight", "Robert Jordan & Brandon Sanderson", "978-0765325945", 499m);
        Book aMemoryOfLight = new Book("A Memory of Light", "Robert Jordan & Brandon Sanderson", "978-0765325952", 499m);

        // Legger til bøker i boksamlingen og i lageret.
        bookStoreManager.AddBook(eyeOfTheWorld, 10);
        bookStoreManager.AddBook(theGreatHunt, 8);
        bookStoreManager.AddBook(theDragonReborn, 12);
        bookStoreManager.AddBook(theShadowRising, 7);
        bookStoreManager.AddBook(theFiresOfHeaven, 6);
        bookStoreManager.AddBook(lordOfChaos, 9);
        bookStoreManager.AddBook(aCrownOfSwords, 5);
        bookStoreManager.AddBook(thePathOfDaggers, 11);
        bookStoreManager.AddBook(wintersHeart, 8);
        bookStoreManager.AddBook(crossroadsOfTwilight, 4);
        bookStoreManager.AddBook(knifeOfDreams, 10);
        bookStoreManager.AddBook(theGatheringStorm, 15);
        bookStoreManager.AddBook(towersOfMidnight, 13);
        bookStoreManager.AddBook(aMemoryOfLight, 14);

        // Setter noen bøker til å være på salg. 
        eyeOfTheWorld.IsBookOnSale = true;
        theGreatHunt.IsBookOnSale = true;
        theDragonReborn.IsBookOnSale = true;
        theShadowRising.IsBookOnSale = true;
        theFiresOfHeaven.IsBookOnSale = true;

        // Teste FindBook metoden.
        Book bookOnSale = bookStoreManager.FindBook("978-0812511819");
        Book bookNotOnSale = bookStoreManager.FindBook("Towers of Midnight");

        Console.WriteLine(bookOnSale.ToString());
        Console.WriteLine(bookNotOnSale.ToString());
        
        // Lager kundeobjekter med og uten mellomnavn.
        Customer andreas = new("Andreas", "Hansen", "andreas@gmail.com", "90948899");
        Customer ole = new("Ole", "Hansen", "ole@popit.no", "90768256", "Gunnar");

        Console.WriteLine(ole.ToString());
        
        // Simulere en ordre.
        Console.WriteLine("Simulere en ordre:");

        Order testOrdre = bookStoreManager.PurchaseBook(andreas, "978-0812513752");

        Console.WriteLine(testOrdre.ToString());
        */
    }
}