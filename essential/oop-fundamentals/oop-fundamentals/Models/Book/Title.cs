using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models.Book
{
    public class Title
    {
        private string innerText;

        public string InnerText
        {
            get => innerText ?? "...";
            set
            {
                if (String.IsNullOrEmpty(value)) throw new NullReferenceException();

                innerText = value;
            }
        }

        public virtual void Show()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{InnerText}");
        }
    }
}
