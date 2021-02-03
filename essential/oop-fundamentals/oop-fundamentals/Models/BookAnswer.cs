using oop_fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using oop_fundamentals.Models.Book;

namespace oop_fundamentals.Models
{
    public class BookAnswer : ITaskAnswer
    {
        public void Process()
        {
            Book.Book book = new Book.Book("War and Peace", "Tolstoy L.N", "Well, Prince, so Genoa and Lucca are now just family estates of the Buonapartes...");
            book.Show();
        }
    }
}
