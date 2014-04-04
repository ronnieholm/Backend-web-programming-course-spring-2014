using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise22 {
    class Runner {
        public void Run() {
            Book b1 = new Book("AD1337", "Java for All", "John Potter", 352);
            Book b2 = new Book("XS3220", "Gardening", "Alex Sohn", 220);
            Book b3 = new Book("DD0095", "Cars in the USA", "Susan Dreyer", 528);
            Book b4 = new Book("PT1295", "Copenhagen Dawn", "Dan Mygind", 104);

            BookCatalog theCatalog = new BookCatalog();
            theCatalog.AddBook(b1);
            theCatalog.AddBook(b2);
            theCatalog.AddBook(b3);
            theCatalog.AddBook(b4);

            Console.WriteLine("------------- Printing all books ---------------");
            theCatalog.PrintAllBooks();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            SafePrintBookInformation(theCatalog.LookupBook("AD1337"));
            SafePrintBookInformation(theCatalog.LookupBook("AD1338"));
            SafePrintBookInformation(theCatalog.LookupBook("PT1295"));
            SafePrintBookInformation(theCatalog.LookupBook("......"));
            SafePrintBookInformation(theCatalog.LookupBook("ad1337"));
        }

        public void SafePrintBookInformation(Book aBook) {
            if (aBook == null) {
                Console.WriteLine("Book was null");
            } else {
                Console.WriteLine(aBook.GetAllInformation());
            }
        }
    }

    class BookCatalog {
        private List<Book> books;

        public BookCatalog() {
            books = new List<Book>();
        }

        public void AddBook(Book aBook) {
            // Add code that can add the given Book object to the list
        }

        public void PrintAllBooks() {
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement
        }

        public Book LookupBook(string isbn) {
            Book matchingBook = null;

            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You will need a repetition statement

            return matchingBook;
        }
    }
}
