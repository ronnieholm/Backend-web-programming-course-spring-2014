using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise24 {
    class SolutionRunner {
        public void Run() {
            Book b1 = new Book("AD1337", "Java for All", "John Potter", 352);
            Book b2 = new Book("XS3220", "Gardening", "Alex Sohn", 220);
            Book b3 = new Book("DD0095", "Cars in the USA", "Susan Dreyer", 528);
            Book b4 = new Book("PT1295", "Copenhagen Dawn", "Dan Mygind", 104);

            BookCatalogSolution theCatalog = new BookCatalogSolution();
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
                Console.WriteLine("Book was null...");
            }
            else {
                Console.WriteLine(aBook.GetAllInformation());
            }
        }
    }

    class BookCatalogSolution {
        private Dictionary<string, Book> books;

        public BookCatalogSolution() {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(Book aBook) {
            // Add the given Book object to the Dictionary
            // ISBN is the Key for a Book object
            books.Add(aBook.GetISBN(), aBook);
        }

        public void PrintAllBooks() {
            // For all books in the Dictionary, print out information for each book
            foreach (KeyValuePair<string, Book> kvp in books) {
                Book b = kvp.Value;
                Console.WriteLine(b.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn) {
            Book matchingBook = null;

            // See if a book with the given key (isbn) is in the Dictionary
            if (books.ContainsKey(isbn)) {
                matchingBook = books[isbn]; // Now matchingBook refers to the book with the matching ISBN
            }

            return matchingBook;
        }
    }
}
