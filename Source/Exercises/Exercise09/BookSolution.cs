using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise09 {
    class MyCode {
        public void MyMain() {
            // 2a
            BookSolution b1 = new BookSolution("12345678", "SomeTitle", "SomeAuthor", 29.95);

            // 2b
            b1.PrintInformation();

            // 2c
            b1.BorrowFromLibrary();
            b1.PrintInformation();

            // 2d
            b1.ReturnToLibrary();
            b1.PrintInformation();

            // 4
            BookSolution b2 = new BookSolution("23456789", "SomeTitle", "SomeAuthor", 9.95);
            b2.PrintInformation();
            b2.BorrowFromLibrary();
            b2.PrintInformation(); 
        }
    }

    class BookSolution {
        // Instance fields
        private string isbnCode;
        private string title;
        private string author;
        private double price;
        private bool bookIsLoanedOut;

        // 3a
        private int numberOfLoans;

        // Constructor
        public BookSolution(string isbnCode, string title, string author, double price) {
            this.isbnCode = isbnCode;
            this.title = title;
            this.author = author;
            this.price = price;
            this.bookIsLoanedOut = false;

            // 3b
            this.numberOfLoans = 0;
        }

        // Just some standard Get methods
        public string GetIsbnCode() {
            return isbnCode;
        }

        public string GetTitle() {
            return title;
        }

        public string GetAuthor() {
            return author;
        }

        public double GetPrice() {
            return price;
        }

        public bool GetBookIsLoanedOut() {
            return bookIsLoanedOut;
        }


        // The below two methods are supposed to be called when a user
        // loans the book from the library and returns the book to the library.
        public void BorrowFromLibrary() {
            bookIsLoanedOut = true;

            // 3c
            numberOfLoans++;
        }

        // 3d
        public int GetNumberOfLoans() {
            return numberOfLoans;
        }

        public void ReturnToLibrary() {
            bookIsLoanedOut = false;
        }

        // Prints out complete information about the book
        public void PrintInformation() {
            // 3e
            Console.WriteLine("ISBN {0} : {1}, by {2}  (price {3}) {4}", isbnCode, title, author, price, numberOfLoans);
            Console.WriteLine();
        }

        // Just a little helper method to make the printing of book
        // information look nicer. Don't worry about how this method works...
        private string LoanStatus() {
            if (bookIsLoanedOut) {
                return "book is loaned out";
            }
            else {
                return "book is NOT loaned out";
            }
        }
    }
}
