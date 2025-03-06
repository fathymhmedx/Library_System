namespace Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");
            Library library = new Library();
            Console.WriteLine("Are you librarian or regular user (L/R)");

            char userType = Console.ReadLine().ToUpper()[0];

            if(userType == 'L')
            {
                Console.WriteLine("Welcome Librarian, Enter your name");
                string librarianName = Console.ReadLine();

                // Librarin Logic
                Librarian l1 = new Librarian(librarianName);

                Console.WriteLine($"Welcome {l1.Name}");
                
                Console.WriteLine("Please choose to Add book (A) / Remove book (R) / Display Book (D).");
                char choice = Console.ReadLine().ToUpper()[0];
                
                switch(choice)
                {
                    case 'A':
                        Console.WriteLine("Enter book details");
                        string BookName = Console.ReadLine();
                        string BookAuthor = Console.ReadLine();
                        int BookYear = Convert.ToInt32(Console.ReadLine());
                        Book book = new Book()
                        {
                            Title = BookName,
                            Author = BookAuthor,
                            Year = BookYear,
                        };
                        l1.AddBook(book, library);
                        break;
                    case 'R':
         
                        Console.WriteLine("Enter book details to remove");
                        BookName = Console.ReadLine();
                        BookAuthor = Console.ReadLine();
                        BookYear = Convert.ToInt32(Console.ReadLine());
                        book = new Book()
                        {
                            Title = BookName,
                            Author = BookAuthor,
                            Year = BookYear,
                        };
                        l1.RemoveBook(book, library);
                        break;

                    case 'D':
                        Console.WriteLine("The Book List: ");
                        l1.DisplayBooks(library);
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }
            }
            else if(userType == 'R')
            {
                // User Logic
            }
            else
            {
                Console.WriteLine("Please enter correct value (L or R)");
            }



        }
    }
}
