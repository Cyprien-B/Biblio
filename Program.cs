using Biblio;

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

while (true)
{
    Console.WriteLine("Choix :");
    Console.WriteLine("1 Ajouter un livre");
    Console.WriteLine("2 Lister les livres");
    Console.WriteLine("3 Supprimer un livres");
    Console.WriteLine("4 Lister les utilisateurs");
    Console.WriteLine("5 Creer un utilisateur");
    Console.WriteLine("6 Selectionner un utilisateur");
    Console.WriteLine("7 Emprunter un livre");

    string choixUtilisateur = Console.ReadLine();

    switch (choixUtilisateur)
    {
        default:
            Console.Clear();
            break;
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
        case "2":
            Console.WriteLine("Les livres disponibles sont les suivants : ");
            foreach (Book book in SeccionLibrary.GetBooks())
            {
                if (book.available)
                {
                    Console.WriteLine($" {book.GetTitle()} {book.getISBN}");
                }

            }
            Console.WriteLine("");
            break;
        case "3":
            Console.WriteLine("Inndiquer un ISBN : ");
            int ISBNToDelete = Convert.ToInt32(Console.ReadLine());
            if (ISBNToDelete != null)
            {
                Book BookToDelete = SeccionLibrary.FindBook(ISBNToDelete);
                SeccionLibrary.Remove(BookToDelete);
            }
            break;
        case "4":
            foreach (User user in SeccionUsers)
            {

                Console.WriteLine(user.GetName());


            }
            break;
        case "5":

            break;
        case "6":
            break;
        case "7":
            break;

    }
}
