using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    class LibraryManager
    {
        private List<Book> books = new List<Book>();
        private List<Borrower> borrowers = new List<Borrower>();


        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Boken '{book.Title}' har lagt till i bibloteket.");

        }

        public void AddBorrower(Borrower borrower)
        {
            borrowers.Add(borrower);
            Console.WriteLine($"Låntagaren '{borrower.Name}' har lagts till");
        }

        public void BorrowBook(string borrowerName, string bookTitle)
        {
            Borrower borrower = borrowers.Find(b => b.Name.ToLower()  == borrowerName.ToLower());

            Book book = books.Find(b => b.Title.ToLower() ==  bookTitle.ToLower());

            if (borrower != null && book != null )
            {
                borrower.BorrowBook(book);
            }
            else
            {
                Console.WriteLine("Låntager eller bok hittades inte");
            }
        }

        public void ReturnBook(string borrowerName, string bookTitle)
        {
            Borrower borrower = borrowers.Find(b => b.Name.ToLower() == borrowerName.ToLower());
            Book book = books.Find(b => b.Title.ToLower() == bookTitle.ToLower());

            if(borrower != null && book != null )
            {
                borrower.ReturnBook(book);

            }
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("Alla böcker i bibloteket : ");

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

        }

        public void ShowAvalibleBooks()
        {
            Console.WriteLine("Tillgängliga böcker : ");
            foreach (var book in books.Where(b => b.isAvaible))
            {
                Console.WriteLine(book);
            }
        }


    }
}
