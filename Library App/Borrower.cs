using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    class Borrower
    {
       public string Name { get; }
       private List<Book> borrowedBooks = new List<Book>();


        public Borrower(string name)
        {
            Name = name;
        }
        public void BorrowBook(Book book)
        {
            if(book.isAvaible)
            {
                borrowedBooks.Add(book);

                book.Borrow();

                Console.WriteLine($"{Name} har lånat {book.Title}");
            }
            else
            {
                Console.WriteLine($"Boken {book.Title} är redan utlånad.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                book.Return();

                Console.WriteLine($"{Name} har återlämnat {book.Title}");
            }
            else
            {
                Console.WriteLine($"{Name} har inte lånat {book.Title}");

            }
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine($"{Name}s lånade böcker :");
            if (borrowedBooks.Count > 0)
            {
                foreach (var book in borrowedBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("Inga böcker lånade.");
            }
        }
    }
}
