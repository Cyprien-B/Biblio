﻿using System;
using System.ComponentModel;


namespace Biblio;

public class User
{
    private string Name { get; set; }
    private string Surname { get; set; }

    public bool IsPremium { get; set; } = true;
    public List<Book> Books { get; set; } = new List<Book>();

    public User(string Name,String Surname)
    {
        this.Name = Name;
        this.Surname = Surname;
    }
    public void addBook(Book book)
    {

        Books.Add(book);

    }

    public string GetName()
    {
        return this.Name ;
    }
}
