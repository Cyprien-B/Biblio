using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace Biblio;

public class Library
{
    private int Id { get; set; }
    private string Name { get; set; }
    private List<Book> Books { get; set; } = new List<Book>();
    public void AddBookToLibrary(Book book)
    {

        Books.Add(book);

    }

    public void Remove(Book book)
    {

        Books.Remove(book);

    }

    public List<Book> GetBooks()
    {
        return Books;
    }

    public Book FindBook(int SearchISBN)
    {
        var BookFind = Books.FirstOrDefault(x => x.getISBN() == SearchISBN);
        if (BookFind != null)
        {
            return BookFind;
        }
        else
        {
            Console.WriteLine("ce livre n'existe pas");
            return null;
        }

    }





}
