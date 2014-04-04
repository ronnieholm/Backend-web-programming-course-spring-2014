using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise22 {
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
        private List<Book> books;

        public BookCatalogSolution() {
            books = new List<Book>();
        }

        public void AddBook(Book aBook) {
            // Add the given Book object to the List
            books.Add(aBook);
        }

        public void PrintAllBooks() {
            // For all the books, print out the information for each book
            foreach (Book b in books) {
                Console.WriteLine(b.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn) {
            Book matchingBook = null;

            // Look through all the books in the List
            foreach (Book b in books) {
                if (b.GetISBN() == isbn) { // We got a match!
                    matchingBook = b; // Now matchingBook refers to the book with the matching ISBN
                }
            }

            return matchingBook;
        }
    }
}
