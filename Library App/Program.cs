using Library_App;

class Program
{
    static void Main()
    {
        LibraryManager manager = new LibraryManager(); 

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n Välj ett alternativ.");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Lägg till lånetagare");
            Console.WriteLine("3. Låna ut bok");
            Console.WriteLine("4. Returnera bok");
            Console.WriteLine("5. Visa alla böcker");
            Console.WriteLine("6. Visa tillgängliga böcker");
            Console.WriteLine("7. Avsluta");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange titel:");
                    string title = Console.ReadLine();

                    Console.Write("Ange författare:");
                    string author = Console.ReadLine();

                    Book newBook = new Book(title, author);
                    manager.AddBook(newBook);


                    break;

                case "2":
                    Console.Write("Ange lånetagarens namn:");
                    string borrowerName = Console.ReadLine();

                    Borrower newBorrower = new Borrower(borrowerName);
                    manager.AddBorrower(newBorrower);

                    break;

                case "3":
                    Console.Write("Ange låntagarens namn:");
                    string borrowerForLoan = Console.ReadLine();

                    Console.Write("Ange boktitel:");
                    string bookToBorrow = Console.ReadLine();

                    manager.BorrowBook(borrowerForLoan, bookToBorrow);

                    break;

                case "4":
                    Console.Write("Ange låntagarens namn:");
                    string borrowerForReturn = Console.ReadLine();

                    Console.Write("Ange boktitel:");
                    string bookToReturn = Console.ReadLine();

                    manager.ReturnBook(borrowerForReturn, bookToReturn);

                    break;

                case "5":
                    manager.ShowAllBooks();
                    break;

                case "6":
                    manager.ShowAvalibleBooks();
                    break;

                case "7":
                    exit = true;
                    break;



                default:
                    Console.WriteLine("Ogiltligt val, försök igen.");
                    break;
            }


        }
    }
}
