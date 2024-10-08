﻿using Biblio;

var SeccionLibrary = new Library();
var SeccionUsers = new List<User>();

// Code pour remplir la library
var livre1 = new Book(12, "livre1", "moi", "date");
var livre2 = new Book(22, "livre2", "moi", "date");
var livre3 = new Book(32, "livre3", "moi", "date");
SeccionLibrary.AddBookToLibrary(livre1);
SeccionLibrary.AddBookToLibrary(livre2);
SeccionLibrary.AddBookToLibrary(livre3);

//code pour remplir par un user
var user1 = new User("Nom1", "Prenom");
SeccionUsers.Add(user1);

Console.WriteLine("Choix :");
Console.WriteLine("1 Ajouter un livre");
Console.WriteLine("2 Lister les livres");
Console.WriteLine("3 Supprimer un livre");
Console.WriteLine("4 Lister les utilisateurs");
Console.WriteLine("5 Créer un utilisateur");
Console.WriteLine("6 Supprimer un utilisateur");
Console.WriteLine("7 Emprunter un livre");
Console.WriteLine("8 Lister les livres empruntés");


while (true)
{
    Console.WriteLine("");
    Console.WriteLine("votre choix :");
    string choixUtilisateur = Console.ReadLine();

    switch (choixUtilisateur)
    {
        default:
            Console.Clear();
            Console.WriteLine("Choix :");
            Console.WriteLine("1 Ajouter un livre");
            Console.WriteLine("2 Lister les livres");
            Console.WriteLine("3 Supprimer un livre");
            Console.WriteLine("4 Lister les utilisateurs");
            Console.WriteLine("5 Créer un utilisateur");
            Console.WriteLine("6 Supprimer un utilisateur");
            Console.WriteLine("7 Emprunter un livre");
            Console.WriteLine("8 Lister les livres empruntés");

            break;

            //Ajouter un livre
        case "1":
            Console.WriteLine("Quelle est le nom du livre ?");
            string NameLivre = Console.ReadLine();
            Console.WriteLine("Quel est le nom de l'auteur ");
            string AutheurLivre = Console.ReadLine();
            Console.WriteLine("Quel est la date de publication");
            string publichdateLivre = Console.ReadLine();
            Console.WriteLine("ISBN");
            int ISBNLivre = Convert.ToInt32(Console.ReadLine());
            if (NameLivre != null && AutheurLivre != null && publichdateLivre != null)
            {
                var Livre = new Book(ISBNLivre, NameLivre, AutheurLivre, publichdateLivre);
                SeccionLibrary.AddBookToLibrary(Livre);


            }
            else
            {
                Console.WriteLine("Vous n'avez pas remplit tout les champs");
            }
            break;

            //Lister les livres dispo
        case "2":
            Console.WriteLine("Les livres disponibles sont les suivants : ");
            foreach (Book book in SeccionLibrary.GetBooks())
            {
                if (book.available)
                {
                    Console.WriteLine($" {book.GetTitle()} {book.getISBN()}");
                }

            }
            Console.WriteLine("");
            break;

            //Supprimer un livre
        case "3":
            Console.WriteLine("Indiquer un ISBN : ");
            int ISBNToDelete = Convert.ToInt32(Console.ReadLine());
            if (ISBNToDelete != null)
            {
                Book BookToDelete = SeccionLibrary.FindBook(ISBNToDelete);
                SeccionLibrary.Remove(BookToDelete);
                Console.WriteLine("livre Supprimer");
            }
            break;

            //Lister les utilisateurs
        case "4":
            Console.WriteLine("Les utilisateur sont les suivants : ");
            foreach (User user in SeccionUsers)
            {
                Console.WriteLine(user.GetName());

            }
            break;

            //Ajouter un utilisateur
        case "5":
            Console.WriteLine("Quelle est le nom de L'utilisateur");
            string nomUtilisateur = Console.ReadLine();
            Console.WriteLine("Quelle est le prenom de L'utilisateur");
            string prenomUtilisateur = Console.ReadLine();

            if (nomUtilisateur != null & prenomUtilisateur != null)
            {
                var userToAdd = new User(nomUtilisateur, prenomUtilisateur);
                SeccionUsers.Add(userToAdd);
                Console.WriteLine($"Utilisateur {nomUtilisateur} ajouter");
            } else
            {
                Console.WriteLine($"nom ou prenom invalide");
            }

            break;

            //Supprimer un utilisateur
        case "6":
            Console.WriteLine("Donner le nom de l'utilisateur a supprimer");
            string nameUserToDelete = Console.ReadLine();

            User userToDelete = SeccionUsers.Find(x => x.GetName() == nameUserToDelete);
            if(userToDelete != null)
            {
                SeccionUsers.Remove(userToDelete);
                Console.WriteLine("Utilisateur Supprimer");
                break;
            }
            Console.WriteLine("Pas d'utilisateur trouver avec ce nom");
            break;

            //Emprunt de livre
        case "7":
            Console.WriteLine("Donner le nom de la personne qui emprunte le livre");
            string nameUserWhoBorrow = Console.ReadLine();
            User UserWhoBorrow = SeccionUsers.Find(x => x.GetName() == nameUserWhoBorrow);
            if (UserWhoBorrow != null)
            {
                int nbrLivre = UserWhoBorrow.Books.Count();
                if(nbrLivre > 2 && !UserWhoBorrow.IsPremium || nbrLivre > 4)
                {
                    Console.WriteLine("Vous avez atteint le nombre limite de livre");
                    break ;
                }
                Console.WriteLine("Indiquer un ISBN : ");
                int ISBNToBorrow = Convert.ToInt32(Console.ReadLine());
                if (ISBNToBorrow != null)
                {
                    Book bookToBorrow = SeccionLibrary.FindBook(ISBNToBorrow);
                    bookToBorrow.available = false;
                    UserWhoBorrow.addBook(bookToBorrow);
                    Console.WriteLine("Livre emprunter");
                    break;
                }
            }
            Console.WriteLine("L'utilisateur ou le livre n'existe pas");
            break;
        case "8":
            foreach (Book book in SeccionLibrary.GetBooks())
            {
                if (!book.available)
                {
                    Console.WriteLine($" {book.GetTitle()} {book.getISBN()}");
                }

            }
            break;

    }
}
