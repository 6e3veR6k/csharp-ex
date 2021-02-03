using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models.Book
{
    public class Book
    {
        private Author author = new Author();
        private Title title = new Title();
        private Content content = new Content();


        public string Author 
        { 
            get => author.FullName;
            set => author.FullName = value;
        }

        public string Title
        {
            get => title.InnerText;
            set => title.InnerText = value;
        }

        public string Content
        {
            get => content.InnerText;
            set => content.InnerText = value;
        }


        public Book(string title): this(title, "No Name", "...")
        {
        }

        public Book(string title, string author): this(title, author, "...")
        {
        }

        public Book(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public virtual void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
