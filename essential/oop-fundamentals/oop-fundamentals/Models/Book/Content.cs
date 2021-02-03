using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models.Book
{
    public class Content
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{InnerText}");
        }
    }
}
