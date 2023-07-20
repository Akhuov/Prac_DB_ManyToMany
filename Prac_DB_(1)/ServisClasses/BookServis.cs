using Prac_DB__1_.DataBase;
using Prac_DB__1_.Interfaces;
using Prac_DB__1_.Models;

namespace Prac_DB__1_.ServisClasses
{
    public class BookServis : IServis
    {
        public static DB db = new DB();
        public void Create()//Create??
        {
            Console.Write("Enter new Book`s Name: ");
            string name = Console.ReadLine();
            if (!db.Books.Any(l => l.Name.Equals(name)))
            {
                db.Add(new Book()
                {
                    Name = name,
                });
                Console.WriteLine("New Book Added");
                db.SaveChanges();
            }
            else { Console.WriteLine("Error!"); ; }
        }
        public void Update()//Update
        {
            Console.Write("Enter Book`s ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new (updating) Book`s Name: ");
            string name = Console.ReadLine();

            var book = db.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                book.Name = name;
                db.SaveChanges();
                Console.WriteLine("Book`s Name Changed!");
            }
            else Console.WriteLine("Error Book's Not Found!");
        }
        public void Delete()
        {

            Console.Write("Enter Book`s ID: ");
            int id = int.Parse(Console.ReadLine());

            var book = db.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                Console.WriteLine("Book Deleted!");
            }
            else Console.WriteLine("Error BookId Not Found!");

        }//Delete
        public object Get()//Get
        {
            Console.Write("Enter Book`s ID: ");
            int id = int.Parse(Console.ReadLine());

            var book = db.Books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                return book;
            }
            else { return null; }
        }
    }
}
