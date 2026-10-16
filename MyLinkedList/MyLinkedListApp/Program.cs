using System.Globalization;

namespace MyLinkedListApp;

class Program
{
    static void Main(string[] args)
    {
        MyLinkedList list = new MyLinkedList();

        // Format per line -> title;author;isbn;publishDate;pages;price;genre
        string path = "books.txt";

        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');
                
                if(parts.Length != 7) continue;

                string title = parts[0];
                string author = parts[1];
                string isbn = parts[2];
                DateTime publishDate = DateTime.Parse(parts[3]);
                int pages = int.Parse(parts[4]);
                decimal price = decimal.Parse(parts[5]);
                BookType genre = Enum.Parse<BookType>(parts[6]);

                Book book = new Book(title, author, isbn, publishDate, pages, price, genre);
                
                list.AddAtEnd(book);
            }
        }

        Console.WriteLine(list);
        
    }
}
