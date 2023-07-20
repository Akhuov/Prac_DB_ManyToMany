using Microsoft.EntityFrameworkCore;
using Prac_DB__1_.DataBase;
using Prac_DB__1_.Interfaces;
using Prac_DB__1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Prac_DB__1_.ServisClasses
{
    public class StaffServis : IServis
    {
        public static DB db = new DB();     
        public void Create()//Create??
        {
            Console.Write("Enter new Staff`s Name: ");
            string name = Console.ReadLine();

            if (!db.Staffs.Any(l => l.Name.Equals(name)))
            {
                db.Add(new Staff()
                    {
                        Name = name,
                    });
                Console.WriteLine("New Staff Added");
                db.SaveChanges();
            }
            else { Console.WriteLine("Error!"); ; }
        }
        public void Update()//Update
        {
            Console.Write("Enter StaffId: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new (updating) Name: ");
            string name = Console.ReadLine();
            var staff = db.Staffs.FirstOrDefault(x => x.Id == id);
            if (staff != null)
            {
                staff.Name = name;
                db.SaveChanges();
                Console.WriteLine("Staff`s Name Changed!");
            }
            else Console.WriteLine("Error Staff's Not Found!");
        }
        public void Delete()
        {
            Console.Write("Enter StaffId: ");
            int id = int.Parse(Console.ReadLine());
            
            var staff = db.Staffs.FirstOrDefault(x => x.Id == id);
            if (staff != null)
            {
                db.Staffs.Remove(staff);
                db.SaveChanges();
                Console.WriteLine("Staff Deleted!");
            }
            else Console.WriteLine("Error StaffId Not Found!");

        }//Delete
        public object Get()//Get
        {
            Console.Write("Enter StaffId: ");
            int id = int.Parse(Console.ReadLine());

            var staffs = db.Staffs.FirstOrDefault(b=>b.Id == id);

            if (staffs != null)
            {
                return staffs;
            }
            else { return null; }
        }
    }
}
