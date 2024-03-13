using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
        }
    }
    class BookShelf
    {
        private Books[] books = new Books[5];
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }

    class Book
    {
        public static void Main()
        {
            Books book1 = new Books("Book1", "Author1");
            Books book2 = new Books("Book2", "Author2");
            Books book3 = new Books("Book3", "Author3");
            Books book4 = new Books("Book4", "Author4");
            Books book5 = new Books("Book5", "Author5");
            BookShelf bookshelf = new BookShelf();

           
            bookshelf[0] = book1;
            bookshelf[1] = book2;
            bookshelf[2] = book3;
            bookshelf[3] = book4;
            bookshelf[4] = book5;

            
            for (int i = 0; i < 5; i++)
            {
                if (bookshelf[i] != null)
                    bookshelf[i].Display();
                else
                    Console.WriteLine("Not assigned");
            }
            Console.ReadKey();
        }
    }
}
