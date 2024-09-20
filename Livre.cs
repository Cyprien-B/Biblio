using System;


namespace Biblio;

public class Book
{
    private int ISBN { get; set; }

    private string Title { get; set; }

    private string Author { get; set; }

    private string? publish_date { get; set; }

    public bool available { get; set; } = true;

    public Book(int ISBN, string title, string author, string? publish_date)
    {
        this.ISBN = ISBN;
        Title = title;
        Author = author;
        this.publish_date = publish_date;
    }

    public int getISBN()
    {
        return this.ISBN;
    }
    public string GetTitle()
    {
        return this.Title;
    }

    public bool isavailable()
    {
        return this.available;
    }

    public void notavailable()
    {
        this.available = false;
    }


}
