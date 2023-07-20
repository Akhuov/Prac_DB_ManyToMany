using Prac_DB__1_.DataBase;
using Prac_DB__1_.Models;
using Prac_DB__1_.ServisClasses;

//DB db = new DB();
//var user = db.Users.FirstOrDefault(u => u.Id == 2);
//var books = db.Books.Where(b => b.Id <= 2).ToList();

//user.Books = books;
//db.SaveChanges();


var userS = new UserServis();
//user.AddNew("Farrux",2);
//user.DeleteByID(5);
//user.UpdateNameById(2,"Davron");
User user = (User)userS.Get();
Console.WriteLine(user.Name);

