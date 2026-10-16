namespace MyLinkedListApp;

public class Book
{
    #region Properties

    public string Title { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
    public DateTime PublishDate { get; private set; }
    public int Pages { get; set; }
    public decimal Price { get; private set; }
    public BookType Genre { get; private set; }

    #endregion

    #region Konstruktor & ToString

    public Book(string title, string author, string isbn, DateTime publishYear, int pages, decimal price, BookType genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublishDate = publishYear;
        Pages = pages;
        Price = price;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"{Title} - {Author} - {Genre} - {ISBN} - {PublishDate} - {Pages} Pages - {Price} Euro.";
    }

    #endregion
}