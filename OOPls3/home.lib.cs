using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPls3
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public Book(string author, string title, int year)
        {
            title = title;
            author = author;
            Year = year;    
        }
        public void Print()
        {
            Console.WriteLine($"Автор{Author} Загаловок {Title} Год издания {Year}");
        }
    }
    class Library
    {
        private List<Book> books;
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public Book SearchAuthor(string author)
        {
            for (int i = 0; i < books.Count;i++)
            {
                if (books[i].Author == author) return books[i];
            }
            return null!;
        }
        
        public Book SearchYears(int years)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if (books[i].Year == years) return books[i];
            }
            return null!;

        }
        public void Print()
        {
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = i + 1; j < books.Count; j++)
                {
                    if (books[i].Year > books[j].Year)
                    {
                        Book temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }
            foreach (Book t in books) t.Print();
        }


        public void Sort()
        {
            for (int i = 0; i < books.Count; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[i].Year!.CompareTo(books[j].Year) > 0)
                    {
                        Book book = books[i];
                        books[i] = books[j];
                        books[j] = book;
                    }
                    else if (books[i].Year!.CompareTo(books[j].Year) == 0)
                    {
                        if (books[i].Year >books[j].Year)
                        {
                            Book book = books[i];
                            books[i] = books[j];
                            books[j] = book;
                        }

                    }
                }
            }
            foreach(Book t in books)
            {
                t.Print();
            }
        }
        
    }
}
