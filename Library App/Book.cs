using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    class Book
    {
        public string Title { get; set; } 

        public string Author { get; set; }

        public bool isAvaible { get; private set; } = true;

        public Book(string title, string author)
        {
            Title = title;

            Author = author;



        }

        public void Borrow()
        {
            isAvaible = false;

        }

        public void Return()
        {
            isAvaible = true;

        }

        public override string ToString()
        {
            string status = isAvaible ? "Tillgänglig" : "Utlånad";
            return $"{Title} av {Author} - Status : {status}";
        }
    }

}
