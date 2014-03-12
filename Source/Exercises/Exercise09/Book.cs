using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise09 {
    class Book {
        // Instance fields
        private string isbnCode;
        private string title;
        private string author;
        private double price;
        private bool bookIsLoanedOut;

        // Constructor
        public Book(string isbnCode, string title, string author, double price) {
            this.isbnCode = isbnCode;
            this.title = title;
            this.author = author;
            this.price = price;
            this.bookIsLoanedOut = false;
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
        }

        public void ReturnToLibrary() {
            bookIsLoanedOut = false;
        }

        // Prints out complete information about the book
        public void PrintInformation() {
            Console.WriteLine("ISBN {0} : {1}, by {2}  (price {3})", isbnCode, title, author, price);
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