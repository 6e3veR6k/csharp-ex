using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models.Book
{
    public class Author
    {
        private string fullName;

        public string FullName
        {
            get => fullName ?? "No Name";
            set
            {
                if (String.IsNullOrEmpty(value)) throw new NullReferenceException();
                    
                fullName = value;
            }
        }

        public virtual void Show()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Author name: {FullName}");
        }
    }
}
