using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Library
    {
        private Book[] books = new Book[100]; // Maximum Capcity
        private int currentBookCount = 0; 
        

        
        private Book[] BorrowBooks = new Book[50];
        private int currentBorrowedBookCount = 0;
        public void Display()
        {
            // Add Logic
            foreach (var book in books) 
                {
                        Console.WriteLine(book.Title);
                }
        }

        public void Add(Book book)
        {
            //Add Logic
            if(currentBookCount < books.Length) 
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added successflly");
            }
            else
            {
                Console.WriteLine("Library is full, can add new books");
            }
        }

        public void Remove(Book book)
        {
            //Add Logic
           int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;
            Console.WriteLine("Book Removed");
        }
    }
}
