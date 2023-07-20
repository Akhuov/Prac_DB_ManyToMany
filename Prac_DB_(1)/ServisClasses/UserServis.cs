using Microsoft.EntityFrameworkCore;
using Prac_DB__1_.DataBase;
using Prac_DB__1_.Interfaces;
using Prac_DB__1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prac_DB__1_.ServisClasses
{
    public  class UserServis : IServis
    {
        public static DB db = new DB();
        public void Create()//Create??
        {
            Console.Write("Enter new User`s Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new User Staff`s Id: ");
            int staffId = int.Parse(Console.ReadLine());

            var staff = db.Staffs.FirstOrDefault(d=>d.Id == staffId);
            if (staff != null)
            {
                db.Add(new User()
                {
                    Name = name,
                    StaffId = staffId,
                });
                Console.WriteLine("User Added");
                db.SaveChanges();
            }
            else Console.WriteLine("Error! Wrong Staff ID!");
        }
        public void Update()//Update
        {
            Console.Write("Enter User`s Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new (updating) User name: ");
            string name = Console.ReadLine();
            var user = db.Users.FirstOrDefault(x=>x.Id == id);
            if (user != null)
            {
                user.Name = name;
                db.SaveChanges();
                Console.WriteLine("Users Name Changed!");
            }
            else Console.WriteLine("Error UserId Not Found!");
        }
        public void Delete() 
        {
            Console.Write("Enter User`s Id: ");
            int id = int.Parse(Console.ReadLine());
            
            var user = db.Users.FirstOrDefault(x=>x.Id == id);
            if(user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                Console.WriteLine("User Deleted!");
            }
            else Console.WriteLine("Error UserId Not Found!");
            
        }//Delete
        public object Get()//Get
        {
            Console.Write("Enter User`s Id: ");
            int id = int.Parse(Console.ReadLine());
            
            User users = db.Users.FirstOrDefault(x=>x.Id ==id);

            if (users !=null)
            {
                return users;   
            }
            else { return null; }
        } 
    }
}


